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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoneyTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserService _userService;
        public MainWindow()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.ShowDialog();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            int result = _userService.Login(new UserLoginModel()
            {
                Login = tbLogin.Text,
                Password = pbPassword.Password
            });
            if (result > 0)
            {
                this.Visibility = Visibility.Hidden;
                MainTrackerWindow tracker = new MainTrackerWindow(result);
                if (tracker.ShowDialog() == true)
                {
                    this.Visibility = Visibility.Visible;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error login or password");
            }
        }
    }
}
