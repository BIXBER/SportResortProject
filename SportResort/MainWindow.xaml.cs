using SportResort.Pages;
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

namespace SportResort
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public static bool IsLoggedIn { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigated += MainFrame_Navigated;
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            // Проверяем текущую страницу
            if (MainFrame.Content is MainPage)
            {
                returnBackButton.IsEnabled = false;
            }
            else
            {
                returnBackButton.IsEnabled = true;
            }
        }

        private void returnBackButton_onClick(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
