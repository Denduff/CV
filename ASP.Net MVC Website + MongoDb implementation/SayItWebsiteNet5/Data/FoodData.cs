using System;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Data
{
    public class FoodData
    {
        public string date { get; set; }
        public string menu { get; set; }
        public List<string> participants { get; set; }
        public FoodData()
        {
            participants = new List<string>();

        }
    }
}
