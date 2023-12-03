using SportResort.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace SportResort.Commands
{
    public class ButtonCommandsViewModel
    {
        public short userRoleId { get; set; }
        public Products SelectedProduct { get; set; }
        public ICommand MainCommand { get; }
        public ICommand LogoutCommand { get; }

        
        public ButtonCommandsViewModel()
        {
            MainCommand = new RelayCommand(NavigateToMainPage);
            LogoutCommand = new RelayCommand(Logout);
        }

        private void NavigateToMainPage(object parameter)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;

            mainWindow?.MainFrame.Navigate(new MainPage(userRoleId));
        }

        private void Logout(object parameter)
        {
            var mainWindow = (MainWindow)App.Current.MainWindow;
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение действия", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    mainWindow?.MainFrame.Navigate(new AuthorizationPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выходе из аккаунта " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }
    }
}
