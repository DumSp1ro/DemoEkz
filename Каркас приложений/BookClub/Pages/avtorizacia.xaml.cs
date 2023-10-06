using BookClub.Classes;
using Microsoft.Win32;
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
    /// Логика взаимодействия для avtorizacia.xaml
    /// </summary>
    public partial class avtorizacia : Page
    {
        public avtorizacia()
        {
            InitializeComponent();
            connect.modelbd = new Models.bookclubEntities();
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            Classes.manager.MainFrame.Navigate(new registr());
        }

        private void Vxod(object sender, RoutedEventArgs e)
        {
            var userObj = connect.modelbd.users.FirstOrDefault(
                x => x.login == Login.Text && Password.Password == x.password);

            if (userObj == null)
            {
                MessageBox.Show("Пользователя с такими данными не существует!", "Ошибка при авторизации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (userObj.id_type == 1)
                {
                    manager.MainFrame.Navigate(new admin());
                }
                else if (userObj.id_type == 2)
                {
                    manager.MainFrame.Navigate(new manag());
                }
                else if (userObj.id_type == 3)
                {
                    manager.MainFrame.Navigate(new user());
                }
            }
        }
    }
}
