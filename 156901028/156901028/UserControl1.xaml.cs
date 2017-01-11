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

namespace _156901028
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        int sayac;
        public UserControl1() 
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email, sifre;
            email = (text1.Text);
            sifre = (sifre1.Password);

            if (email == "admin" && sifre == "12345")
            {
                Window1 Yeni = new Window1();
                Yeni.Show();
                this.Hide();
            }
            else
            {
                sayac = sayac + 1;
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ");
            }

            if (sayac == 3)
            {
                text1.IsEnabled = false;
                sifre1.IsEnabled = false;
                buton1.IsEnabled = false;
            }

        }
        private void Hide()
        {
        }
        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {
            sifre1.Clear();
        }
    }
}