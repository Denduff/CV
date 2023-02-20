using SayItWebsiteNet5.Data;
using SayItWebsiteNet5.Foodclub;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Foodclub
{
    public class BudgetManager
    {
        public List<BudgetEntry> Entries { get; set; }
        public float Food { get; set; } = 2500;
        public float Entertainment { get; set; } = 2500;
        public float Activities { get; set; } = 750;
        public float Creativity { get; set; } = 500;
        public int Units { get; set; } = 22;
        private DBFactory _dBFactory;
 

        public BudgetManager()
        {
            Entries = new List<BudgetEntry>();
            _dBFactory = new DBFactory();
            var nightList = _dBFactory.GetAllDocuments<ClubNight>("SayItWebsiteInfo", "FoodClub");
            foreach(var n in nightList)
            {
                Entries.Add(n.Budget);
            }
        }

        public BudgetData GetBudget()
        {
            CalcRemainingBudget();
            BudgetData data = new BudgetData()
            {
                Food = this.Food,
                Entertainment = this.Entertainment,
                Activities = this.Activities,
                Creativity = this.Creativity,
                EntriesLeft = Units

            };
            return data;
        }

        private void CalcRemainingBudget()
        {
            foreach(var entry in Entries)
            {
                Food -= entry.Food;
                Entertainment -= entry.Entertainment;
                Activities -= entry.Activities;
                Creativity -= entry.Creativity;
                Units -= 1;
            }
        }



    }
}
