using BookClub.Classes;
using BookClub.Pages;
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

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
            manager.MainFrame = MainFrame;
        }

        private void redOrder(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new redOrders());
        }

        private void GoKatalog(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Katalog());
        }
    }
}
