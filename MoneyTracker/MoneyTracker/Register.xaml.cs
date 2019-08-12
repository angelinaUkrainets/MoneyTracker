using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MoneyTracker
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private readonly IUserService _userService;
        public Register()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            int res = _userService.Register(new UserRegistrationModel()
            {
                Name = tbName.Text,
                Surname = tbSurname.Text,
                Email = tbEmail.Text,
                Login = tbLogin.Text,
                Password = tbPassword.Text,
                CashBalance = 0,
                CardBalance = 0,
                IsFirstEnter = false
            });

            if (res > 0)
            {
                this.Close();

                MailAddress from = new MailAddress("moneytrackerrivne@gmail.com", "Money Tracker");
                MailAddress to = new MailAddress(tbEmail.Text);
                MailMessage m = new MailMessage(from, to);

                m.Subject = "Welcome to Money Tracker";
                m.Body = "<h2>Registration was successful</h2>" +
                    "<p>use our program to control your costs and profits</p>";
                m.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("moneytrackerrivne@gmail.com", "moneyTracker1234");
                smtp.EnableSsl = true;
                smtp.Send(m);

                MainWindow login = new MainWindow();
                login.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error Login or Password");
            }
        }
    }
}
