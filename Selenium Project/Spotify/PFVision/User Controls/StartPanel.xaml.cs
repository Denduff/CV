using PFVision.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PFVision.User_Controls
{
    /// <summary>
    /// Interaction logic for StartPanel.xaml
    /// </summary>
    public partial class StartPanel : UserControl
    {
        public StartPanel()
        {
            InitializeComponent();
        }

        private void StartBot_Click(object sender, RoutedEventArgs e)
        {
            MainFrame mf = new MainFrame(PlatformVal.Text);
            
 

        }

    }
}
