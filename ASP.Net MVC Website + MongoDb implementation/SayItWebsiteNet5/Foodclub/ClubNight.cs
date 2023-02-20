using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SayItWebsiteNet5.Foodclub
{
    public class ClubNight
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public BudgetEntry Budget { get; set; }
        public Participants Participants { get; set; } = new Participants();
        public Menu MenuOfDay { get; set; }

    }
}
