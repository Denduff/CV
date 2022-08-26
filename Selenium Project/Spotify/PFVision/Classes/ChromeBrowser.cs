using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;

namespace PFVision.Classes
{
    public class ChromeBrowser
    {
        public ChromeDriver chromebrowser;
        public bool proxy { get; set; }
        public string[] proxylist = {
   
            //redacted

        };

        //refactor to remove proxy option and make proxy default
        public ChromeBrowser(bool proxy) {

            if (proxy == true)
            {
                chromebrowser = CreateProxyBrows();

            }
            else {
                // Non proxy not implemented as of now for safety reasons
            }
            

        }
           
           




        private string getProxy()
        {
            //read proxy from file implement
            var client = new WebClient();
            client.Proxy = new WebProxy(""); //redacted
            client.Proxy.Credentials =
              new NetworkCredential("", ""); //redacted
            return client.DownloadString("");//redacted
        }

        public ChromeDriver CreateProxyBrows()
        {
            Random random = new Random();

            string[] fullprox = proxylist[random.Next(proxylist.Length)].Split(':'); 
     
            string ip = fullprox[0];
            int port = int.Parse(fullprox[1]);
            string usn = fullprox[2];
            string pw = fullprox[3];
            var chromeoptions = new ChromeOptions();
            chromeoptions.AddHttpProxy(ip, port, usn, pw);
            ChromeDriver browser = new ChromeDriver(chromeoptions);
            
            browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            return browser;
        }
    }
}
