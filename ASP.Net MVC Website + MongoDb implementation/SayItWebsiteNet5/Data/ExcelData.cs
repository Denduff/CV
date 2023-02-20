using SayItWebsiteNet5.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SayItWebsiteNet5.Data
{
    public class ExcelData
    {
        public int WeekNumber { get; set; }
        public Protocol? Monday { get; set; }
        public Protocol? Tuesday { get; set; }
        public Protocol? Thursday { get; set; }
        public Protocol? Friday { get; set; }
        public Dictionary<string, List<ProtocolData>> Data => CreateViewData();

        public ExcelData(int weeknum, List<Protocol> protocols)
        {
            WeekNumber = weeknum;
            foreach (Protocol p in protocols)
            {
                switch (p.Date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        Monday = p;
                        break;
                    case DayOfWeek.Tuesday:
                        Tuesday = p;
                        break;
                    case DayOfWeek.Thursday:
                        Thursday = p;
                        break;
                    case DayOfWeek.Friday:
                        Friday = p;
                        break;
                }
            }
        }
        //To Dictionary - søg
        private Dictionary<string, List<ProtocolData>> CreateViewData()
        {
            //check days for null (no protocol)
            if(Monday == null) { Monday = new Protocol() { StudentProtocol = new Dictionary<string, ProtocolData>() }; }
            if(Tuesday == null) { Tuesday = new Protocol() { StudentProtocol = new Dictionary<string, ProtocolData>()}; }
            if(Thursday == null) { Thursday = new Protocol( ) { StudentProtocol = new Dictionary<string, ProtocolData>()}; }
            if(Friday == null) { Friday = new Protocol(){StudentProtocol = new Dictionary<string, ProtocolData>()}; }
            
            Dictionary<string, List<ProtocolData>> data = new Dictionary<string, List<ProtocolData>>();

            var students = Monday.StudentProtocol?.Keys?.Concat(Tuesday.StudentProtocol?.Keys ?? new Dictionary<string, ProtocolData>().Keys)
                                                      ?.Concat(Thursday.StudentProtocol?.Keys ?? new Dictionary<string, ProtocolData>().Keys)
                                                      ?.Concat(Friday.StudentProtocol?.Keys ?? new Dictionary<string, ProtocolData>().Keys)
                                                      ?.Distinct();
            // Fix protocol data
            foreach (var student in students)
            {
                var stdData = new List<ProtocolData>()
                {
                    Monday.StudentProtocol.ContainsKey(student) ? Monday.StudentProtocol[student] : ProtocolData.EmptyProtocol(),
                    Tuesday.StudentProtocol.ContainsKey(student) ? Tuesday.StudentProtocol[student] : ProtocolData.EmptyProtocol(),
                    Thursday.StudentProtocol.ContainsKey(student) ? Thursday.StudentProtocol[student] : ProtocolData.EmptyProtocol(),
                    Friday.StudentProtocol.ContainsKey(student) ? Friday.StudentProtocol[student] : ProtocolData.EmptyProtocol()
                };     

                data.Add(student, stdData);
            }
            return data;
        }
    }
}
