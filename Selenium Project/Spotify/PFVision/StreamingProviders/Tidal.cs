using PFVision.Classes;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using System.IO;
using Newtonsoft.Json;
namespace PFVision.StreamingProviders
{
    public class Tidal
    {
        IList<Song> songList = new List<Song>();
        IList<Account> accountList = new List<Account>();
        public Tidal()
        {
            //fill list of songs from file
            songList = GetSongs();
            //fill list of accounts from file
            accountList = GetAccounts();

        }
        public void LetItRip()
        {
            ConnectAccounts();
            StartPlaying();

            System.Timers.Timer t = new System.Timers.Timer(20000); // 1 sec = 1000, 60 sec = 60000

            t.AutoReset = true;

            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

            t.Start();

            //timer loops infinitely fires off event to start checking if all accounts are still playing
        }
        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Replay();
        }

        //fix
        public void Replay()
        {
            foreach (var acc in accountList)
            {
                try
                {
                    var playElement = acc.browser.chromebrowser.FindElement(By.ClassName("A8NeSZBojOQuVvK4l1pS")).GetAttribute("aria-label");

                    if (playElement == "Play")
                    {

                        var rand = new Random();
                        int index = rand.Next(songList.Count);
                        var song = songList[index];
                        acc.browser.chromebrowser.Navigate().GoToUrl(song.url);
                        Thread.Sleep(10000);
                        var newPlay = acc.browser.chromebrowser.FindElement(By.ClassName("A8NeSZBojOQuVvK4l1pS")).GetAttribute("aria-label");
                        if (newPlay == "Play")
                        {
                            IJavaScriptExecutor js = (IJavaScriptExecutor)acc.browser.chromebrowser;
                            var btn = acc.browser.chromebrowser.FindElement(By.ClassName("A8NeSZBojOQuVvK4l1pS"));
                            js.ExecuteScript("arguments[0].click();", btn);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    continue;
                }
            }
        }

        public IList<Song> GetSongs()
        {       //make it return list of songs

            var file = File.ReadAllText(@"..\..\BotFiles\Songs\Songs.json");

            var songList = JsonConvert.DeserializeObject<Collection<Song>>(file);
            var liste = songList.Where(song => song.streamType.Equals(Song.StreamType.Tidal));
            var linqlist = from song in songList
                           where song.streamType.Equals(Song.StreamType.Tidal)
                           select song;



            return linqlist.ToList(); ;
        }

        public IList<Account> GetAccounts()
        {

            var file = File.ReadAllText(@"..\..\BotFiles\Accounts\Accounts.json");
            var accountList = JsonConvert.DeserializeObject<Collection<Account>>(file);
            var retlist = accountList.Where<Account>(x => x.streamType == Account.StreamType.Tidal);

            return retlist.ToList(); ;
        }
        //fix
        public void ConnectAccounts()
        {
            foreach (var acc in accountList)
            {
                try
                {
                    
                    acc.browser = new ChromeBrowser(true);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)acc.browser.chromebrowser;
                    acc.browser.chromebrowser.Navigate().GoToUrl("https://listen.tidal.com/");
                    var btn = acc.browser.chromebrowser.FindElement(By.Id("login-button"));
                    js.ExecuteScript("arguments[0].click();", btn);
                 //   acc.browser.chromebrowser.FindElement(By.Id("email")).SendKeys(acc.Username);
                    acc.browser.chromebrowser.FindElement(By.CssSelector("button[ui-testc-id='check-user-continue-button']"));
                  //  acc.browser.chromebrowser.FindElement(By.Id("password")).SendKeys(acc.Password);
                    acc.browser.chromebrowser.FindElement(By.Id("password")).Submit();
                    Thread.Sleep(4000);

  
                   // var subbtn = acc.browser.chromebrowser.FindElement(By.CssSelector("[type='submit']")).Click;
                    //js.ExecuteScript("arguments[0].click();", btn);

                    Thread.Sleep(1000);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        public void StartPlaying()
        {
            foreach (var acc in accountList)
            {
                try
                {
                    var rand = new Random();
                    int index = rand.Next(songList.Count);
                    string song = songList[index].url;
                    //FIX
                    //https://stackoverflow.com/questions/48450594/selenium-timed-out-receiving-message-from-renderer
                    //renderer timeout ændre i browser settingss

                    acc.browser.chromebrowser.Navigate().GoToUrl(song);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
