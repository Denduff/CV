using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
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
using PFVision.Classes;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.Windows.Forms;

namespace PFVision.User_Controls
{
    /// <summary>
    /// Interaction logic for AccountOverviewPanel.xaml
    /// </summary>
    public partial class AccountOverviewPanel : System.Windows.Controls.UserControl
    {

        ObservableCollection<Account> Addacclist = new ObservableCollection<Account>();
        ObservableCollection<Account> accList = new ObservableCollection<Account>();
        public AccountOverviewPanel()
        {
            InitializeComponent();
            ObservableCollection<Account> accSth = JsonConvert.DeserializeObject<ObservableCollection<Account>>(File.ReadAllText(@"..\..\BotFiles\Accounts\Accounts.json"));
            accList = accSth;
            FullAccList.ItemsSource = accList;


        }

        private void BtnSingleAccAdd_Click(object sender, RoutedEventArgs e)
        {
            Account tmpAcc = new Account(AccNameBox.Text, PasswordBox.Text, RegionBox.Text, (bool)ProxxyCheckBox.IsChecked);
            accList.Add(tmpAcc);

            string objectInJson = JsonConvert.SerializeObject(accList, Formatting.Indented);
            File.WriteAllText(@"../../BotFiles/Accounts/Accounts.json", objectInJson);
            FullAccList.ItemsSource = accList;
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
            AccountFile.ItemsSource = JsonConvert.DeserializeObject<ObservableCollection<Account>>(fileContent);

            //load file and add to list addacclist using filedialog
        }

        private void BtnFileAccAdd_Click(object sender, RoutedEventArgs e)
        {
            foreach (Account acc in AccountFile.ItemsSource) {
                accList.Add(acc);
            }
            Addacclist.Clear();

            string objectInJson = JsonConvert.SerializeObject(accList, Formatting.Indented);
            File.WriteAllText(@"../../BotFiles/Accounts/Accounts.json", objectInJson);
            // add/append acclist to file.

            AccountFile.ItemsSource = Addacclist;
            FullAccList.ItemsSource = accList;
        }
    }
}
