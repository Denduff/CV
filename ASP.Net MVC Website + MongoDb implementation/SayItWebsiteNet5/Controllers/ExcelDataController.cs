using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Models;
using System;
using System.Globalization;
using System.Linq;

namespace SayItWebsiteNet5.Controllers
{
    public class ExcelDataController : Controller
    {
        private DBFactory _dBFactory;

        public ExcelDataController()
        {
            _dBFactory = new DBFactory();

        }


        //kig lige på det her igen - fix metoden hvormed data bliver sendt.
        [HttpPost]
        public IActionResult Download(string GridHtml)
        {
            var filname = "Protokol_For_" + DateTime.Now.ToShortDateString() + ".xls";
            return File(System.Text.Encoding.UTF8.GetBytes(GridHtml), "application/vnd.ms-excel", filname);
        }

        public IActionResult CreateTable()
        {
            int WeekNumber = ISOWeek.GetWeekOfYear(DateTime.Now);
            var allprotocolsByWeek = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol").Where(x => x.WeekNumber == WeekNumber).ToList();



            ExcelData excelData = new ExcelData(WeekNumber, allprotocolsByWeek);

            return View(excelData);
        }

        [HttpPost]
        [Route("ExcelData/CreateTable/{WeekNumber}")]
        public IActionResult CreateTable(int WeekNumber)
        {
            var allprotocolsByWeek = _dBFactory.GetAllDocuments<Protocol>("SayItWebsiteInfo", "Protocol").Where(x => x.WeekNumber == WeekNumber).ToList();
            ExcelData excelData = new ExcelData(WeekNumber, allprotocolsByWeek);
            return View(excelData);

        }
    }
}
