using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SayItWebsiteNet5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DBFactory _dBFactory;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dBFactory = new DBFactory();
        }

        public IActionResult Index()
        {
            //get event data
            var eventlist = _dBFactory.GetAllDocuments<SIEvents>("SayItWebsiteInfo", "Events");
            //add to viewbag

            var currentEvents = from events in eventlist
                                 where events.Date.Date > DateTime.Now.Date
                                 select events;

            List<object> calenderList = new List<object>();
            foreach(var e in currentEvents)
            {
                dynamic newEvent = new { Description = e.Description, calendar = e.Title, date = e.Date.ToString("yyyy-MM-dd"), color="orange", route=e.Id.ToString()};
                calenderList.Add(newEvent);
            }
            ViewBag.CalenderEvents = calenderList.ToArray();



            //input in cshtml to calenderdata 



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
