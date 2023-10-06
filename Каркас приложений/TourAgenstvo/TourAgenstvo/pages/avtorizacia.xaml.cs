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

namespace TourAgenstvo
{
    /// <summary>
    /// Логика взаимодействия для avtorizacia.xaml
    /// </summary>
    public partial class avtorizacia : Page
    {
        public avtorizacia()
        {
            InitializeComponent();
        }

        private void Vxod(object sender, RoutedEventArgs e)
        {
            if (login.Text == "root" && password.Text == "12345") 
            {
                Manager.MainFrame.Navigate(new admin());
            }
            if (login.Text == "user" && password.Text == "12345")
            {
                Manager.MainFrame.Navigate(new user());
            }
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            password.Visibility = Visibility.Visible;
            password.Text = passwordBox.Password;
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            password.Visibility = Visibility.Collapsed;
        }

    }
}
