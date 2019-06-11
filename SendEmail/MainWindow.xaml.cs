using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendEmail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SmtpClient smtpClient;
        NetworkCredential networkCredential;
        MailMessage mailMessage;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            int flag = 0;

            if (txtTo.Text.Trim().Length == 0)
            {
                flag = 0;
                txtbTo.Text = "Required";
                txtTo.Focus();
            }
            else if (!Regex.IsMatch(txtTo.Text, @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"))
            {
                flag = 0;
                txtbTo.Text = "Invalid";
                txtTo.Focus();
            }
            else
            {
                flag = 1;
                txtbTo.Text = "";
            }
            if (txtSubject.Text.Trim().Length == 0)
            {
                flag = 0;
                txtbSubject.Text = "Required";
                txtSubject.Focus();
            }
            if (txtContent.Text.Trim().Length == 0)
            {
                flag = 0;
                txtbContent.Text = "Required";
                txtContent.Focus();
            }
            if (flag == 1)
            {
                networkCredential = new NetworkCredential("bootcamp26.official@gmail.com", "Bo0tc4mp26-");
                smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = Convert.ToInt32("587");
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = networkCredential;
                mailMessage = new MailMessage { From = new MailAddress("bootcamp26.official@gmail.com", "Bootcamp 26", Encoding.UTF8) };
                mailMessage.To.Add(new MailAddress(txtTo.Text));
                mailMessage.Subject = txtSubject.Text;
                mailMessage.Body = txtContent.Text;
                mailMessage.BodyEncoding = Encoding.UTF8;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;
                mailMessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                smtpClient.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending";
                smtpClient.SendAsync(mailMessage, userstate);
                txtTo.Text = "";
                txtSubject.Text = "";
                txtContent.Text = "";
                txtTo.Focus();
            }
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Your Message has been successfully sent.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtTo.Text = "";
            txtSubject.Text = "";
            txtContent.Text = "";
            txtTo.Focus();

            txtbTo.Text = "";
            txtbSubject.Text = "";
            txtbContent.Text = "";
        }
    }
}
