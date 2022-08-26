using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PFVision.Classes
{
    public class SpotifyAccount
    {
        [BsonId]
        public  ObjectId _id {get;set;}
        public string Username {get;set;}
        public string Password {get;set;}
        public bool IsFunctional { get; set; }
    }
}
