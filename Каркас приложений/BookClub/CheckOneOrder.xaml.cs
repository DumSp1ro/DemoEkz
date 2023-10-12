using BookClub.Pages;
using System.Windows;
using BookClub.Classes;

namespace BookClub
{
    /// <summary>
    /// Логика взаимодействия для CheckOneOrder.xaml
    /// </summary>
    public partial class CheckOneOrder : Window
    {
        public CheckOneOrder()
        {
            InitializeComponent();
            manager.MainFrame = MainFrame;
        }

        private void Buy(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TalonOrder());
        }
    }
}
