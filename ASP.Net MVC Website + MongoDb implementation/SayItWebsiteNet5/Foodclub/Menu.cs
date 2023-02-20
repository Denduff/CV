using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Foodclub
{
    public class Menu
    {
       [BsonId]
       public ObjectId Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public string Link { get; set; }
       public List<Ingredient>? Ingredients { get; set; }
    }
}
