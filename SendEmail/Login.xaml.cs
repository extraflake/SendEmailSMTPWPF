using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendEmail
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(Email_Txt.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                MessageBox.Show("Username must filled by Email", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                Email_Txt.Focus();
            }
            else if (string.IsNullOrWhiteSpace(Email_Txt.Text) || string.IsNullOrWhiteSpace(Password_Txt.Password))
            {
                MessageBox.Show("Username or Password must be Filled", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if(Remember_chk.IsChecked == true)
                {
                    Properties.Settings.Default.UserName = Email_Txt.Text;
                    Properties.Settings.Default.Password = Password_Txt.Password;
                    Properties.Settings.Default.Remme = "yes";
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = Email_Txt.Text;
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Remme = "no";
                    Properties.Settings.Default.Save();
                }
                this.Close();
                MainWindow calling = new MainWindow();
                calling.ShowDialog();
            }
        }

        private void Init_Data()
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.Remme == "yes")
                {
                    Email_Txt.Text = Properties.Settings.Default.UserName;
                    Password_Txt.Password = Properties.Settings.Default.Password;
                    Remember_chk.IsChecked = true;
                }
                else
                {
                    Email_Txt.Text = Properties.Settings.Default.UserName;
                }
            }
        }
    }
}
