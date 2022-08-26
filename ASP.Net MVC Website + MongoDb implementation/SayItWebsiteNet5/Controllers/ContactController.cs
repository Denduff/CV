using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Models;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SayItWebsiteNet5.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(Contact contact)
        {
            string to = ""; //Redacted
            string from = ""; //Redacted

            MailMessage message = new MailMessage(from, to);
            message.Subject = "Besked fra Say-It hjemmesiden";
            message.Body = @contact.Message;
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 25;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("",""); //Redacted
            client.Send(message);

         


            return RedirectToAction("Index");
        }


   
    }
}
