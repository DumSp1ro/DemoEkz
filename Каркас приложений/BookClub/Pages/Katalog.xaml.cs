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

namespace BookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для Katalog.xaml
    /// </summary>
    public partial class Katalog : Page
    {
        public Katalog()
        {
            InitializeComponent();
        }

        private void OpenWindowOneOrder(object sender, RoutedEventArgs e)
        {
            CheckOneOrder checkOneOrder = new CheckOneOrder();
            checkOneOrder.Show();
        }
    }
}
