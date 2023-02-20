using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SayItWebsiteNet5.Controllers
{
    public class ProtocolController : Controller
    {
        private DBFactory _dBFactory;
        public ProtocolController()
        {
            _dBFactory = new DBFactory();
        }
        public IActionResult Index()
        {
            var allprotocols = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol");
            var reversedproto = allprotocols.Reverse();
            //Limit to 10 

            return View(reversedproto);
        }

        [HttpGet]
        public IActionResult TakeProtocol()
        {
            //get student where active = true


            Protocol protocol = new Protocol();
            protocol.StudentProtocol = new Dictionary<string, ProtocolData> { };
            protocol.Date = DateTime.Now;

            var collection = _dBFactory.GetAllDocuments<Student>("SayItWebsiteInfo", "Students").Where(x => x.Active == true);

            foreach (var element in collection)
            {
                protocol.StudentProtocol.Add(element._Id.ToString(), new ProtocolData { Present = false, Note = "", StudentData = element });
            }

            return View(protocol);
        }

        [HttpPost]
        public IActionResult TakeProtocol(Protocol protocol)
        {
            if (protocol.Date == DateTime.MinValue)
            {
                protocol.Date = DateTime.Now;
                protocol.WeekNumber = ISOWeek.GetWeekOfYear(protocol.Date);
            }
            if(protocol.WeekNumber == null)
            {
                protocol.WeekNumber = ISOWeek.GetWeekOfYear(protocol.Date);
            }
            foreach(var element in protocol.StudentProtocol)
            {
                if(element.Value.Note == null)
                {
                    element.Value.Note = "";
                }
            }
            protocol.Date =  protocol.Date.AddHours(2);

            _dBFactory.CreateDocument("SayItWebsiteInfo", "Protocol", protocol);
            

            ModelState.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Protocol/EditProtocol/{ProtocolId}")]
        public IActionResult EditProtocol(string ProtocolId)
        {
            var protocols = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol");
            var protocol = from p in protocols
                           where p.Id.ToString() == ProtocolId
                           select p;

            protocol.FirstOrDefault().SecretId = protocol.FirstOrDefault().Id.ToString();


            //SE SIEVENT CONTROLLER med Subscribe event for at se, hvordan
            //route protocol id, replace current protocol
            return View(protocol.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult EditProtocol(Protocol protocol)
        {
            protocol.Id = ObjectId.Parse(protocol.SecretId);
            var result =  _dBFactory.UpdateOneDocument<Protocol>("SayItWebsiteInfo", "Protocol", protocol);    
            if (result.IsCompletedSuccessfully)
            {
          
          
                return RedirectToAction("Index");
            }

            //fail check ?? add
            return View(protocol);

            
        }



        [HttpGet]
        [Route("Protocol/DetailsProtocol/{ProtocolId}")]
        public IActionResult DetailsProtocol(string ProtocolId)
        {
            var protocols = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol");
            IEnumerable<Protocol> protocol = from p in protocols
                                             where p.Id.ToString() == ProtocolId
                                             select p;



            //route protocol id, replace current protocol
            return View(protocol.FirstOrDefault());
        }
        [HttpGet]
        [Route("Protocol/DeleteProtocol/{ProtocolId}")]
        public IActionResult DeleteProtocol(string ProtocolId)
        {
            var protocols = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol");
            var protocol = from p in protocols
                           where p.Id.ToString() == ProtocolId
                           select p;

            _dBFactory.DeleteDocument<Protocol>("SayItWebsiteInfo", "Protocol", protocol.FirstOrDefault());



            //route protocol id, replace current protocol
            return RedirectToAction("Index");
        }
    }
}
