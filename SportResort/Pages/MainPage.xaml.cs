using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Product> Products { get; set; }

        public MainPage()
        {
            InitializeComponent();
            DataContext = this;

            Products = new ObservableCollection<Product>();
            Products.Add(new Product { ImageUrl = "/Media/Products/Images/ProfileIcon.png", Title = "Продукт 1", Price = 10 });
            Products.Add(new Product { ImageUrl = "/Media/Products/Images/Product2.png", Title = "Продукт 2", Price = 20 });
            Products.Add(new Product { ImageUrl = "/Media/Products/Images/Product3.png", Title = "Продукт 3", Price = 30 });
        }
    }

    public class Product
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
