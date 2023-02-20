namespace SayItWebsiteNet5.Foodclub
{
    public class Ingredient
    {
       public Ingredient()
        {

        }
       public Ingredient(string name, float price, float amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public string Name { get; set; }
       public float Price { get; set; }
       public float Amount { get; set; }
    }
}
