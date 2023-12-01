using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace SportResort.Pages
{
    public partial class MainPage : Page
    {
        public short UserRoleId { get; set; }
        public MainPage(short userRoleId)
        {
            InitializeComponent();

            UserRoleId = userRoleId;
            SetPermission(UserRoleId);

            using (var dbContext = new SportResortEntities())
            {
                IControlProductsList.ItemsSource = dbContext.Products.ToList();
            }
        }

        private void CardProductButton_onClick(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ((Button)sender).DataContext as Products;
            NavigationService?.Navigate(new ProductDetailPage(selectedProduct, UserRoleId));
        }

        private void AddProductButton_onClick(object sender, RoutedEventArgs e)
        {
            bool saveButtonVisible = false;
            NavigationService?.Navigate(new ProductFormPage(new Products(), saveButtonVisible, UserRoleId));
        }

        private void SetPermission(short userRoleId)
        {
            switch (userRoleId)
            {
                case 1:
                    buttonAddProduct.Visibility = Visibility.Visible;
                    break;
                case 2:
                    buttonAddProduct.Visibility = Visibility.Collapsed;
                    break;
                default:
                    buttonAddProduct.Visibility = Visibility.Collapsed;
                    break;
            }
        }
        
    }
}
