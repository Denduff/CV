using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using SayItWebsiteNet5.Foodclub;
using System.Linq;
using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ServiceStack.Text;
using System.Text;
using System.Linq.Expressions;
using MongoDB.Bson;

namespace SayItWebsiteNet5.Controllers
{
    public class FoodClubController : Controller
    {

        private UserManager<ApplicationUser> _userManager;
        private DBFactory dBFactory;
        private List<Ingredient> _IngredientList;
        private string UserId;
        private SignInManager<ApplicationUser> _signInManager;
        private BudgetManager _budgetManager;

        public FoodClubController(UserManager<ApplicationUser> user, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = user;
            dBFactory = new DBFactory();
            _IngredientList = new List<Ingredient>();
            _signInManager = signInManager;
            _budgetManager = new BudgetManager();

        }
        static DateTime GetNextWeekday(DayOfWeek day)
        {
            DateTime result = DateTime.Now;
            while (result.DayOfWeek != day)
                result = result.AddDays(1);
            return result;
        }

        public IActionResult Index()
        {


            if (HttpContext.User.IsInRole("FoodClub"))
            {
                try
                {
                    var NextNight = dBFactory.GetAllDocuments<ClubNight>("SayItWebsiteInfo", "FoodClub").Where(x => x.Budget.Day.Date == GetNextWeekday(DayOfWeek.Tuesday).Date).First();
                    return View(NextNight);
                }
                catch
                {
                    var tempnight = new ClubNight()
                    {
                        Id = new MongoDB.Bson.ObjectId(),
                        Budget = new BudgetEntry(),
                        MenuOfDay = new Menu()
                        {
                            Id = new MongoDB.Bson.ObjectId(),
                            Name = "Der er ingen aften oprettet endnu",
                            Description = "",
                            Link = ""


                        }
                    };
                    return View(tempnight);
                }
            }
            else
            {
                return RedirectToAction("SignUp");
            }


        }


        public IActionResult GetFoodNight(string id)
        {
            var FoodNight = dBFactory.GetOneDocument<ClubNight>("SayItWebsiteInfo", "FoodClub", id, false);

            return View(FoodNight);
        }

        public IActionResult SignUp()
        {
            return View();
        }
        public async Task<IActionResult> PostSignUp()
        {
            UserId = _userManager.GetUserId(HttpContext.User);
            var User = await _userManager.GetUserAsync(HttpContext.User);
            Student student = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", UserId, true);
            //maybe get all if exist don't create



            var res = dBFactory.CreateDocument<Student>("SayItWebsiteInfo", "FoodClubMembers", student);
            await _userManager.AddToRoleAsync(User, "FoodClub");

            ViewBag.SignedUpMessage = "Log ud og ind igen for at se madklubben.";
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "home");
        }

        public IActionResult UnsubscribeToNight(string id)
        {
            var clubNight = dBFactory.GetOneDocument<ClubNight>("SayItWebsiteInfo", "FoodClub", id, false);
            var user = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", _userManager.GetUserId(HttpContext.User), true);
            if (!clubNight.Participants.ParticipantList.Any(x => x._Id == user._Id))
            {
                //Do some error handling here, as the user should definitely exist
            }
            else
            {
                clubNight.Participants.ParticipantList.Remove(user);
                var result = dBFactory.GetDb("SayItWebsiteInfo").GetCollection<ClubNight>("FoodClub").ReplaceOne(Builders<ClubNight>.Filter.Eq("_id", clubNight.Id), clubNight);
                if (result.IsAcknowledged == false)
                {
                    //error handling on failed to update
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult SubscribeToNight(string id)
        {
            //get clubnight
            var ClubNight = dBFactory.GetOneDocument<ClubNight>("SayItWebsiteInfo", "FoodClub", id, false);
            //get User
            string AppUserId = _userManager.GetUserId(HttpContext.User);
            var participant = dBFactory.GetOneDocument<Student>("SayItWebsiteInfo", "Students", AppUserId, true);


            if (!ClubNight.Participants.ParticipantList.Any(x => x._Id == participant._Id))
            {
                ClubNight.Participants.ParticipantList.Add(participant);
                var doc = dBFactory.GetDb("SayItWebsiteInfo").GetCollection<ClubNight>("FoodClub");
                var result = doc.ReplaceOne(Builders<ClubNight>.Filter.Eq("_id", ClubNight.Id), ClubNight);
                if (result.IsAcknowledged == true)
                {
                    ViewBag.Message = "Du er nu tilmeldt til eventet";
                }
            }
            else
            {
                ViewBag.Message = "Du er allerede tilmeldt";

            }



            return RedirectToAction("Index");
        }


        [Route("/DayId")]
        public IActionResult GetMenuOfDay(string Id)
        {
            return View();
        }

        public IActionResult PostMenuSuggestion(Menu MenuItem)
        {
            //check to see if name already exists first.
            dBFactory.CreateDocument<Menu>("SayItWebsiteInfo", "FoodClubMenuItems", MenuItem);
            return View();
        }

        public IActionResult GetSuggestedMenuItems()
        {
            var MenuItems = dBFactory.GetAllDocuments<Menu>("SayItWebsiteInfo", "FoodClubMenuItems");
            return View(MenuItems);
        }


        public IActionResult DownloadClubNights()
        {
            var nights = dBFactory.GetAllDocuments<ClubNight>("SayItWebsiteInfo", "FoodClub");
            List<FoodData> data = new List<FoodData>();
            foreach (ClubNight n in nights)
            {
                FoodData nightdata = new FoodData();
                nightdata.date = n.Budget.Day.ToShortDateString();
                nightdata.menu = n.MenuOfDay.Name;
                List<string> part = new List<string>();
                foreach (var p in n.Participants.ParticipantList)
                {
                    nightdata.participants.Add(p.Name + " " + p.Surname);
                }

                data.Add(nightdata);

            }

            return File(Encoding.UTF8.GetBytes(CsvSerializer.SerializeToString(data)),
                 "application/vnd.ms-excel", "Madklubsudtræk " + DateTime.Now.ToShortDateString());
        }



        //admin stuff below here

        public IActionResult CreateClubNight()
        {
            return View();
        }
        public IActionResult PostClubNight(ClubNight Night)
        {
            dBFactory.CreateDocument("SayItWebsiteInfo", "FoodClub", Night);
            return RedirectToAction("Index");
        }

        public IActionResult CreateMenuItem()
        {

            return View();
        }
        public IActionResult UpdateIngredientList()
        {
            _IngredientList.Add(new Ingredient(HttpContext.Request.Form["name"], float.Parse(HttpContext.Request.Form["antal"]), float.Parse(HttpContext.Request.Form["pris"])));


            return ViewComponent("IngredientList", _IngredientList);
        }

        public IActionResult DeleteNight(string id)
        {
            var clubToDelete = dBFactory.GetOneDocument<ClubNight>("SayItWebsiteInfo", "FoodClub", id, false);
            dBFactory.DeleteDocument<ClubNight>("SayItWebsiteInfo", "FoodClub", clubToDelete);

            return RedirectToAction("Index");
        }
        public IActionResult GetBudget()
        {
            
            var budget = _budgetManager.GetBudget();
          
            return View(budget);
        }

        public IActionResult PostReceipt()
        {
            return View();
        }

        public IActionResult GetReceipts()
        {
            return View();
        }

        public IActionResult GenerateReport()
        {
            return View();
        }

        public IActionResult DownloadReport()
        {
            return View();
        }

        public IActionResult GetMenuItems()
        {
            return View();
        }
    }
}
