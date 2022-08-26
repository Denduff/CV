using PFVision.Classes;
using PFVision.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PFVision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        TabItem _tabUserPage;
        private void BtnAccOverview_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new AccountOverviewPanel();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void BtnTracklist_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new TracklistPanel();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void BtnGenerated_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new GeneratedPanel();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void BtnEarnings_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new EarningsPanel();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear();
            var userControls = new StartPanel();
            _tabUserPage = new TabItem { Content= userControls };
            MainTab.Items.Add(_tabUserPage);
            MainTab.Items.Refresh();


           // MainFrame mf = new MainFrame(MainFrame.StreamType.Tidal);
           // MainFrame mf2 = new MainFrame(MainFrame.StreamType.Spotify);

        }
    }
}
