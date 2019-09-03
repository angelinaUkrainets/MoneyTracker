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
        public MainTrackerWindow(int res)
        {
            InitializeComponent();
            IdUser = res;
        }

        private void Pluss_Click(object sender, RoutedEventArgs e)
        {
            //Button button = new Button();
            //button.Content = "wadawd";
            //button.Height = 80;
            //button.Width = 150;
            //grid.Children.Add(button);
            PlusWindow window = new PlusWindow(IdUser);
            window.ShowDialog();
        }
    }
}
