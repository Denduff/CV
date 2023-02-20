using System.ComponentModel.DataAnnotations;

namespace SayItWebsiteNet5.Data
{
    public class BudgetData
    {
        [Display(Name = "Mad")]
        public float Food { get; set; }
        [Display(Name = "Underholdning")]
        public float Entertainment { get; set; }
        [Display(Name = "Aktiviteter")]
        public float Activities { get; set; }
        [Display(Name = "Kreativitet")]
        public float Creativity { get; set; }
        [Display(Name = "Aftener tilbage")]
        public float EntriesLeft { get; set; }


    }
}
