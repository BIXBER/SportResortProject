﻿using System;
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

        public MainPage()
        {
            InitializeComponent();
            using (var dbContext = new SportResortEntities())
            {
                IControlProductsList.ItemsSource = dbContext.Products.ToList();
            }
        }

        private void CardProductButton_onClick(object sender, RoutedEventArgs e)
        {
            var selectedProduct = ((Button)sender).DataContext as Products;
            NavigationService?.Navigate(new ProductDetailPage(selectedProduct));
        }

        private void AddProductButton_onClick(object sender, RoutedEventArgs e)
        {
            bool saveButtonVisible = false;
            NavigationService?.Navigate(new ProductFormPage(new Products(), saveButtonVisible));
        }
        
    }

    
}
