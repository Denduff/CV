using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFVision.Classes
{
    public class Song
    {
        public string title { get; set; }
        public int duration { get; set; }
        public int views { get; set; }
        public string url { get; set; }
        public StreamType streamType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StreamType
        {
            Spotify,
            Deezer,
            Napster,
            Apple,
            Tidal
        } 


        public Song()
        {
            
        }

        public Song(string Title, int Duration, string Url)
        {
            url = Url;
            duration = Duration;
            title = Title;
          
        }
    }
}
