using SportResort.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SportResort.Commands
{
    public class ButtonCommandsViewModel
    {
        public short userRoleId { get; set; }
        public Products SelectedProduct { get; set; }
        public ICommand MainCommand { get; }

        
        public ButtonCommandsViewModel()
        {
            MainCommand = new RelayCommand(NavigateToMainPage);

        }

        private void NavigateToMainPage(object parameter)
        {
            // Получение основного окна приложения
            var mainWindow = App.Current.MainWindow as MainWindow;

            // Проверка наличия основного окна
            if (mainWindow != null)
            {
                // Навигация на MainPage
                mainWindow.MainFrame.Navigate(new MainPage(userRoleId));
            }
        }
    }
}
