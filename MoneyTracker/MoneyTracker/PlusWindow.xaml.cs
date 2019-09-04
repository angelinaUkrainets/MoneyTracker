using DLL.Entities;
using MoneyTracker.Windows;
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
    /// Interaction logic for PlusWindow.xaml
    /// </summary>
    public partial class PlusWindow : Window
    {
        private readonly int IdUser;
        private EFContext _context = new EFContext();
        private string _imageSource;
        public PlusWindow(int res)
        {
            InitializeComponent();
            IdUser = res;
        }

        public PlusWindow(string Img)
        {
            InitializeComponent();
            _imageSource = Img;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Done_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _context.Categories.Add(new Category()
                {
                    Name = tbNameCategory.Text,
                    UserId = IdUser,
                    Summ = 0,
                    ImageSource = _imageSource
                });
                _context.SaveChanges();
            }
            catch {
                MessageBox.Show("Cannot add category");
            };
        }

        private void New_Button_Click(object sender, RoutedEventArgs e)
        {
            IconWindow icon = new IconWindow();
            this.Close();
            icon.ShowDialog();
        }
    }
}
