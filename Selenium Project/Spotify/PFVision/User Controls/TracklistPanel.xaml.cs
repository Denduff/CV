
using Newtonsoft.Json;
using PFVision.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PFVision.User_Controls
{
    /// <summary>
    /// Interaction logic for TracklistPanel.xaml
    /// </summary>
    public partial class TracklistPanel : System.Windows.Controls.UserControl
    {
        ObservableCollection<Song> tracklist = new ObservableCollection<Song>();
        ObservableCollection<Song> tracksAddlist = new ObservableCollection<Song>();

        public TracklistPanel()
        {
            InitializeComponent();
            ObservableCollection<Song> songSth = JsonConvert.DeserializeObject<ObservableCollection<Song>>(File.ReadAllText(@"..\..\Botfiles\Songs\Songs.json"));
            tracklist = songSth;
            FullTrackList.ItemsSource = tracklist;

       
        }

        private void BtnFileSearch_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (var openFileDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            tracksAddlist = JsonConvert.DeserializeObject<ObservableCollection<Song>>(fileContent);

            TrackFilesToAddList.ItemsSource = tracksAddlist;

        }

        private void BtnAddAboveTracks_Click(object sender, RoutedEventArgs e)
        {
            foreach (Song song in tracksAddlist)
            {
                tracklist.Add(song);
            }
            tracksAddlist.Clear();

            string objectInJson = JsonConvert.SerializeObject(tracklist, Formatting.Indented);
            File.WriteAllText(@"../../BotFiles/Songs/Songs.json", objectInJson);
            // add/append acclist to file.

            TrackFilesToAddList.ItemsSource = tracksAddlist;
            FullTrackList.ItemsSource = tracklist;
        }

        private void BtnSingleTrackAdd_Click(object sender, RoutedEventArgs e)
        {
            Song tmpSong = new Song(TitleBox.Text, Int32.Parse(DurationBox.Text), UrlBox.Text);
            tracklist.Add(tmpSong);
  

            string objectInJson = JsonConvert.SerializeObject(tracklist, Formatting.Indented);
            File.WriteAllText(@"../../BotFiles/Songs/Songs.json", objectInJson);
            FullTrackList.ItemsSource = tracklist;
        }


        private Song GetSongInfo(string url)
        {
            //search web for track info then add to file

            //Do something along the lines of this Visual Basic script - It's scrambled as fuck, but works

            //    If tbSongURL.Text.Contains("https://open.spotify.com/track/") Then
            //   Dim URL As String = tbSongURL.Text
            //    Dim ID = GetClosedText(URL, "/track/", "?si=")
            //    CurrentSongID = ID
            //    Dim request As HttpWebRequest
            //    Dim response As HttpWebResponse = Nothing
            //    Dim reader As StreamReader
            //    request = DirectCast(WebRequest.Create("https://embed.spotify.com/oembed?url=spotify:track:" & ID), HttpWebRequest)
            //    response = DirectCast(request.GetResponse(), HttpWebResponse)
            //    reader = New StreamReader(response.GetResponseStream())
            //    Dim rawresp As String
            //    rawresp = reader.ReadToEnd()
            //    Dim ImageUrl = GetClosedText(rawresp, "thumbnail_url" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & "," & ControlChars.Quote & "thumbnail_width")
            //    Dim tClient As WebClient = New WebClient
            //    Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(ImageUrl)))
            //    pbCover.Image = tImage
            //    lbTitle.Text = GetClosedText(rawresp, "title" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & "," & ControlChars.Quote & "thumbnail_url")


            //    Dim web_client As WebClient = New WebClient

            //    ' Download the file.
            //    If Not(My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory &"\BotFiles\Covers\" & ID & ".jpg")) Then
            //        web_client.DownloadFile(ImageUrl,
            //        My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Covers\" & ID & ".jpg")
            //    End If
            //    Inireader.WertSchreiben("Details", "ID", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", ID)
            //    Inireader.WertSchreiben("Details", "URL", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", URL)
            //    Inireader.WertSchreiben("Details", "TrackName", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", GetClosedText(rawresp, "title" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & ", " & ControlChars.Quote & "thumbnail_url"))
            //    Inireader.WertSchreiben("Details", "Views", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", 0)
            //    Inireader.WertSchreiben("Details", "Duration", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", DurationSeconds.Text)
            //End If


            //make it return the song
            return null;
        }


    }
}
