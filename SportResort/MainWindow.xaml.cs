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
            ProductFormPage productFormPage = MainFrame.Content as ProductFormPage;
            
            if (productFormPage != null)
            {
                try
                {
                    bool hasUnsavedNewProduct = productFormPage.hasUnsavedNewProduct;
                    bool hasUnsavedChanges = productFormPage.hasUnsavedChanges;
                    if (hasUnsavedChanges)
                    {
                        MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите отменить изменения?", "Подтверждение действия", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                        {
                            MainFrame.GoBack();
                        }
                    }
                    else if (hasUnsavedNewProduct)
                    {
                        MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите отменить создание нового товара?", "Подтверждение действия", MessageBoxButton.YesNo);
                        if (result == MessageBoxResult.Yes)
                        {
                            MainFrame.GoBack();
                        }
                    }
                    else
                    {
                        MainFrame.GoBack();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при возврате на предыдущую страницу {ex.Message}", "Ошибка изменения товара");
                }
            }
            else
            {
                MainFrame.GoBack();
            }
        }
    }
}
