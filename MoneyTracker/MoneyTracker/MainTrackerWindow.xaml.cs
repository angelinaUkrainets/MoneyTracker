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
        public MainTrackerWindow(int res)
        {
            InitializeComponent();
        }

        private void Pluss_Click(object sender, RoutedEventArgs e)
        {
            PlusWindow window = new PlusWindow();
            window.ShowDialog();
        }
    }
}
