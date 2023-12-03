using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using SportResort.Commands;


namespace SportResort.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductDetailPage.xaml
    /// </summary>
    public partial class ProductDetailPage : Page
    {
        public Products SelectedProduct { get; set; }
        public short UserRoleId { get; set; }

        public ProductDetailPage(Products selectedProduct, short userRoleId)
        {
            InitializeComponent();
            SelectedProduct = selectedProduct;
            UserRoleId = userRoleId;
            SetPermission(UserRoleId);
            
            DataContext = new ButtonCommandsViewModel()
            {
                SelectedProduct = SelectedProduct,
                userRoleId = userRoleId
            };
             
        }

        private void buttonEditProduct_onClick(object sender, RoutedEventArgs e)
        {
            Products editable_product = SelectedProduct;
            bool saveButtonVisible = true;
            NavigationService?.Navigate(new ProductFormPage(editable_product, saveButtonVisible, UserRoleId));
        }

        private void buttonDeleteProduct_onClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить этот товар?", "Подтверждение действия", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    using (var dbContext = new SportResortEntities())
                    {
                        dbContext.Products.Attach(SelectedProduct);
                        dbContext.Products.Remove(SelectedProduct);
                        dbContext.SaveChanges();
                    }
                    NavigationService?.Navigate(new MainPage(UserRoleId));
                    MessageBox.Show($"Товар {SelectedProduct.title} был успешно удален из каталога", "Удаление товара", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении товара: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SetPermission(short userRoleId)
        {
            switch (userRoleId)
            {
                case 1:
                    editProductStackPanel.Visibility = Visibility.Visible;
                    break;
                case 2:
                    editProductStackPanel.Visibility = Visibility.Visible;
                    break;
                default:
                    editProductStackPanel.Visibility = Visibility.Hidden;
                    break;
            }
        }

    }
}
