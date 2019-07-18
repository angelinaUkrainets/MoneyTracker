using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
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
                Password = tbPassword.Text
            });
            if (res > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Login or Password");
            }
        }
    }
}
