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

namespace MoneyTracker.Windows
{
    /// <summary>
    /// Interaction logic for IconWindow.xaml
    /// </summary>
    public partial class IconWindow : Window
    {
        private string _imgSource;
        public IconWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Done_Button_Click(object sender, RoutedEventArgs e)
        {
            PlusWindow window = new PlusWindow(_imgSource);
            this.Close();
            window.ShowDialog();
        }

        private void New_Button_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img7.Source.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img8.Source.ToString();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img9.Source.ToString();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img1.Source.ToString();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img2.Source.ToString();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img3.Source.ToString();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img4.Source.ToString();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img5.Source.ToString();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img6.Source.ToString();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img10.Source.ToString();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img11.Source.ToString();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img12.Source.ToString();
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img13.Source.ToString();
        }

        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img14.Source.ToString();
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img15.Source.ToString();
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img16.Source.ToString();
        }
  
        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img17.Source.ToString();
        }

        private void Button18_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img18.Source.ToString();
        }

        private void Button19_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img19.Source.ToString();
        }

        private void Button20_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img20.Source.ToString();
        }

        private void Button21_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img21.Source.ToString();
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img22.Source.ToString();
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img23.Source.ToString();
        }

        private void Button24_Click(object sender, RoutedEventArgs e)
        {
            _imgSource = Img24.Source.ToString();
        }
    }
}
