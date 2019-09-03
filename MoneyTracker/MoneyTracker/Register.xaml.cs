using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private static EFContext context = new EFContext();
        public Register()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var cashBal = double.Parse(tbCash.Text);
            var cardBal = double.Parse(tbCard.Text);
            int res = 0;
            try
            {
                var user = new UserRegistrationModel()
                {
                    Name = tbName.Text,
                    Surname = tbSurname.Text,
                    Email = tbEmail.Text,
                    Login = tbLogin.Text,
                    Password = tbPassword.Text,
                    CashBalance = cashBal,
                    CardBalance = cardBal
                };
                res = _userService.Register(user);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (res > 0)
            {

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
