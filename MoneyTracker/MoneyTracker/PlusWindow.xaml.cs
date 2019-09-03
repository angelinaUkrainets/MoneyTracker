using DLL.Entities;
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
        public PlusWindow(int res)
        {
            InitializeComponent();
            IdUser = res;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Done_Button_Click(object sender, RoutedEventArgs e)
        {
            _context.Categories.Add(new Category()
            {
                Name = tbNameCategory.Text,
                UserId = IdUser, 
                Summ = 0
            });
            _context.SaveChanges();
        }
    }
}
