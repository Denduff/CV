using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFVision.Classes
{
    public class Account
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public string Region { get; set; }
        public bool Proxy { get; set; }
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

        public ChromeBrowser browser { get; set; }
        public string current_song { get; set; }

        //refactor to remove proxy option
        public Account(string usn, string pw, string Country, bool proxy)
        {
            Username = usn;
            Password = pw;
            Region = Country;
            Proxy = proxy;
        }




    }
}
