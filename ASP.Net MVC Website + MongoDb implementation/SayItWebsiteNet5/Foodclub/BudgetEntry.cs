using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SayItWebsiteNet5.Foodclub
{
    public class BudgetEntry
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public float Food { get; set; }
        public float Entertainment { get; set; }
        public float Activities { get; set; }
        public float Creativity { get; set; }
        public DateTime Day { get; set; }
        
    }
}
