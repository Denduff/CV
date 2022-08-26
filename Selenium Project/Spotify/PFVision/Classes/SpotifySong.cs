using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFVision.Classes
{
    public class SpotifySong
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string url { get; set; }

    }
}
