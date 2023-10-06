using BookClub.Classes;
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
    /// Логика взаимодействия для registr.xaml
    /// </summary>
    public partial class registr : Page
    {
        public registr()
        {
            InitializeComponent();
            connect.modelbd = new Models.bookclubEntities();
        }

        private void Registraciya(object sender, RoutedEventArgs e)
        {
            // Получаем данные из полей ввода
            string login = Login.Text;
            string password = Password.Password;
            string confirmPassword = ConfirmPassword.Password;

            // Создаем нового пользователя
            var newUser = new Models.users
            {
                login = login,
                password = password,
                id_type = 3 // 3 соответствует роли "Client"
            };

            // Добавляем пользователя в таблицу users
            connect.modelbd.users.Add(newUser);

            try
            {
                // Сохраняем изменения в базе данных
                connect.modelbd.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!", "Успешная регистрация",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка при регистрации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
