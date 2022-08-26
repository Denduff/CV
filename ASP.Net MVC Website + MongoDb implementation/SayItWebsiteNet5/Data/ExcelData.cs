using SayItWebsiteNet5.Models;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Data
{
    public class ExcelData
    {
        int WeekNumber { get; set; }
        Student student { get; set; }
       // List<Protocol> protocols { get; set; } populate days
        
        string Monday { get; set; } // non-default getter med private fields -> bool fravær + string note 
        string Tuesday { get; set; }
        string Thursday { get; set; }
        string Friday { get; set; }
    }
}
