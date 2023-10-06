using BookClub.Classes;
using BookClub.Models;
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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        public admin()
        {
            InitializeComponent();
            CRUDUser.ItemsSource = bookclubEntities.GetContext().users.ToList();

        }

        private void DelUser(object sender, RoutedEventArgs e)
        {
            var clientsForRemoving = CRUDUser.SelectedItems.Cast<Models.users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {clientsForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    bookclubEntities.GetContext().users.RemoveRange(clientsForRemoving);
                    bookclubEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    CRUDUser.ItemsSource = bookclubEntities.GetContext().users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {

        }

        private void UserEdit(object sender, RoutedEventArgs e)
        {

        }
    }
}
