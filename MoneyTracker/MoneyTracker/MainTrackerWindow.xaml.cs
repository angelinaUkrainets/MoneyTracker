using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MoneyTracker
{
    /// <summary>
    /// Interaction logic for MainTrackerWindow.xaml
    /// </summary>
    public partial class MainTrackerWindow : Window
    {
        private readonly int IdUser;
        public string login, password;
        public MainTrackerWindow(int res, string login_, string password_)
        {
            InitializeComponent();
            IdUser = res;
            login = login_;
            password = password_;
        }

        private void Pluss_Click(object sender, RoutedEventArgs e)
        {
            PlusWindow window = new PlusWindow(IdUser);
            window.ShowDialog();
        }

        private void Category1_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Clothing";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category2_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Dining";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category3_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Education";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category4_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Freetime";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category5_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Health";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category6_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Home";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }

        private void Category7_Click(object sender, RoutedEventArgs e)
        {
            string categoryName = "Transport";
            CostWindow window = new CostWindow(categoryName, login, password);
            window.ShowDialog();
        }
    }
}
