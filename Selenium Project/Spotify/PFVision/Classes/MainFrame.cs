using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Timers;
using Newtonsoft.Json;
using System.IO;
using PFVision.StreamingProviders;
using Newtonsoft.Json.Converters;

namespace PFVision.Classes
{
    public class MainFrame
    {
     
        ////Test setup
        //Collection<string> testsongs = new Collection<string>();
        //Collection<Account> testaccs = new Collection<Account>();
        // End of test setup



        public MainFrame(string streamtype)
        {
            switch (streamtype)
            {
                case "Spotify":
                    Spotify spotify = new Spotify();
                    spotify.LetItRip();
                    break;
                case "Deezer":
                    break;

                case "Apple":
                    break;

                case "Napster":
                    break;

                case "Tidal":
                    Tidal tidal = new Tidal();
                    tidal.LetItRip();
                    break;
                
                default: break;

            }
        }
        
        































        /// <summary>
        /// Test stuff
        /// </summary>
        //public void testCode()
        //{

        //    Thread.Sleep(1000);

        //    //ChromeBrowser bws1 = new ChromeBrowser(false);
        //    //ChromeBrowser bws2 = new ChromeBrowser(false);
        //    //ChromeBrowser bws3 = new ChromeBrowser(false);
        //    //ChromeBrowser bws4 = new ChromeBrowser(false);
        //    //ChromeBrowser bws5 = new ChromeBrowser(false);
        //    //ChromeBrowser bws6 = new ChromeBrowser(false);
        //    //ChromeBrowser bws7 = new ChromeBrowser(false);
        //    //ChromeBrowser bws8 = new ChromeBrowser(false);
        //    //ChromeBrowser bws9 = new ChromeBrowser(false);
        //    //ChromeBrowser bws10 = new ChromeBrowser(false);
        //    //ChromeBrowser bws11 = new ChromeBrowser(false);

        //    //bws1.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws2.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws3.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws4.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws5.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws6.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws7.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws8.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws9.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws10.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");
        //    //bws11.chromebrowser.Navigate().GoToUrl("https://whatismyipaddress.com/");


        //    ////Test fixture

        //    ////check if songs are still up, if not pick new ones for now
        //    testsongs.Add("https://open.spotify.com/track/3ogVz9roXacTs7IB5M8SZi?si=7ee7ef10275749af");
        //    testsongs.Add("https://open.spotify.com/track/4DPeCnGSfKkdsCVAOwNaJe?si=a5bc146b857f4e41");
        //    testsongs.Add("https://open.spotify.com/track/2CYmIvca4tyDpYOa9X3X97?si=ad73bdf0eef942f7");
        //    testsongs.Add("https://open.spotify.com/track/0uEXgWdba2Vp0Ssulgja4t?si=f863ef037ea941cb");
        //    testsongs.Add("https://open.spotify.com/track/55QgxlCuR6x3V4eN2TaGgY?si=207bcf44d1154ef1");
        //    ////testsongs.Add("");
        //    ////testsongs.Add("");
        //    ////testsongs.Add("");
        //    //testaccs.Add(acc1);
        //    //testaccs.Add(acc2);
        //    //testaccs.Add(acc3);
        //    //testaccs.Add(acc4);
        //    //testaccs.Add(acc5);
        //    //testaccs.Add(acc6);
        //    //testaccs.Add(acc7);
        //    //testaccs.Add(acc8);
        //    //testaccs.Add(acc9);
        //    //testaccs.Add(acc10);
        //    //testaccs.Add(acc11);
        //    //testaccs.Add(acc12);
        //    //testaccs.Add(acc13);
        //    //testaccs.Add(acc14);
        //    //testaccs.Add(acc15);
        //    //testaccs.Add(acc16);

        //    foreach (var acc in testaccs)
        //    {
        //        try
        //        {
        //            var rand = new Random();
        //            int index = rand.Next(testsongs.Count);
        //            acc.current_song = testsongs[index];
        //            acc.browser = new ChromeBrowser(false);
        //            acc.browser.chromebrowser.Navigate().GoToUrl("https://accounts.spotify.com/en/login/");
        //            acc.browser.chromebrowser.FindElement(By.Id("login-username")).SendKeys(acc.Username);
        //            acc.browser.chromebrowser.FindElement(By.Id("login-password")).SendKeys(acc.Password);
        //            Thread.Sleep(4000);

        //            IJavaScriptExecutor js = (IJavaScriptExecutor)acc.browser.chromebrowser;
        //            var btn = acc.browser.chromebrowser.FindElement(By.Id("login-button"));
        //            js.ExecuteScript("arguments[0].click();", btn);


        //            Thread.Sleep(1000);

        //            acc.browser.chromebrowser.Navigate().GoToUrl(testsongs[index]);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.ToString());
        //        }
        //    }


        //    System.Timers.Timer t = new System.Timers.Timer(20000); // 1 sec = 1000, 60 sec = 60000

        //    t.AutoReset = true;

        //    t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

        //    t.Start();
        //}
    }
}
