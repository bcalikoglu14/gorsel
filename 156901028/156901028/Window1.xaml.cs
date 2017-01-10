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
using System.Net;

namespace _156901028
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public class bilgi
        {
            public string ilacAdi { get; set; }
            public string etkenMadde { get; set; }
            public string form { get; set; }
            public string tarih { get; set; }
        }
        public Window1()
        {
            InitializeComponent();
        }

        private void yeniKayit(object sender, RoutedEventArgs e)
        {

        }

        private void guncelle(object sender, RoutedEventArgs e)
        {

        }

        private void kayitSil(object sender, RoutedEventArgs e)
        {

        }

        private void temizle(object sender, RoutedEventArgs e)
        {

        }

        private void cikis(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
