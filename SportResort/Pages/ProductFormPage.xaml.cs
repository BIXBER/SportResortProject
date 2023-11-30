using Microsoft.Win32;
using System;
using System.IO;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using System.Windows.Input;

namespace SportResort.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class ProductFormPage : Page
    {
        public bool SaveButtonVisible { get; set; }
        private byte[] imageBytes;
        private string imageFilePath;
        public short userRoleId { get; set; }
        public Products EditableProduct { get; set; }
        
        public ProductFormPage(Products editableProduct, bool saveButtonVisible)
        {
            InitializeComponent();
            EditableProduct = editableProduct;
            DataContext = EditableProduct;
            this.userRoleId = userRoleId;

            if (saveButtonVisible)
            {
                buttonSaveChangesOfProduct.Visibility = Visibility.Visible;
                buttonAddProduct.Visibility = Visibility.Hidden;
                buttonAddAnotherYetProduct.Visibility = Visibility.Hidden;
            }
        }
        private void costTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void buttonBrowseImage_onClick(object sender, RoutedEventArgs e)
        {
            string imagePath = SelectImage();
            if (!string.IsNullOrEmpty(imagePath))
            {
                imgPhoto.Source = new BitmapImage(new Uri(imagePath));
                imageBytes = File.ReadAllBytes(imagePath);
                imageFilePath = imagePath;
            }
        }

        private string SelectImage()
        {
            string imagePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == true)
            {
                imagePath = openFileDialog.FileName;
            }

            return imagePath;
        }

        private void SaveImageToWorkingDirectory()
        {
            if (!string.IsNullOrEmpty(imageFilePath))
            {
                string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
                string imagesFolderPath = Path.Combine(projectDirectory, "Media", "Products", "Images");
                Directory.CreateDirectory(imagesFolderPath);
                string fileName = $"{Guid.NewGuid()}{Path.GetExtension(imageFilePath)}";
                string destinationPath = Path.Combine(imagesFolderPath, fileName);

                File.Copy(imageFilePath, destinationPath);
            }
        }
            

        private Dictionary<string, object> ParseFieldsAndCompleteObject()
            {
                bool answer = false;

                if (yesRadioButton.IsChecked == true)
                {
                    answer = true;
                }
                else if (noRadioButton.IsChecked == true)
                {
                    answer = false;
                }

                decimal cost;
                bool isValidCost = decimal.TryParse(productCostTextBox.Text, out cost);

                if (!isValidCost)
                {
                    MessageBox.Show("Указано некорректное значение стоимости товара.");
                    return null;
                }

                Dictionary<string, object> productAttributes = new Dictionary<string, object>
                {
                    { "title", productTitleTextBox.Text },
                    { "description", productDescriptionTextBox.Text },
                    { "cost", cost },
                    { "is_available", answer },
                    { "image", imageBytes }
                };

                return productAttributes;
            }

        private void buttonAddAnotherYetProduct_onClick(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> productAttributes = ParseFieldsAndCompleteObject();

            if (productAttributes != null)
            {
                Products product = new Products
                {
                    title = (string)productAttributes["title"],
                    description = (string)productAttributes["description"],
                    cost = (decimal)productAttributes["cost"],
                    is_available = (bool)productAttributes["is_available"],
                    image = (byte[])productAttributes["image"]
                };
                SaveProductToDatabase(product);
            }
            SaveImageToWorkingDirectory();
            ClearFormFields();
        }

        private void buttonAddProduct_onClick(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> productAttributes = ParseFieldsAndCompleteObject();

            if (productAttributes != null)
            {
                Products product = new Products
                {
                    title = (string)productAttributes["title"],
                    description = (string)productAttributes["description"],
                    cost = (decimal)productAttributes["cost"],
                    is_available = (bool)productAttributes["is_available"],
                    image = (byte[])productAttributes["image"]
                };
                SaveProductToDatabase(product);
            }

            SaveImageToWorkingDirectory();
            NavigationService?.Navigate(new MainPage(userRoleId));
        }

        private void SaveProductToDatabase(Products product)
        {
            try
            {
                using (var dbContext = new SportResortEntities())
                {
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении товара в базу каталоге: {ex.Message}" +
                    $"\n\nСкорее всего Вы не ввели данные в обязательные поля или ввели их неверно.", "Ошибка изменения товара");
            }
        }

        private void EditProductToDatabase(Products product)
        {
            try
            {
                using (var dbContext = new SportResortEntities())
                {
                    var existingProduct = dbContext.Products.Find(product.id);

                    if (existingProduct != null)
                    {
                        dbContext.Entry(existingProduct).CurrentValues.SetValues(product);
                        dbContext.SaveChanges();
                        MessageBox.Show("Товар был успешно изменен в каталоге!", "Успешное изменение");
                    }
                    else
                    {
                        MessageBox.Show("Товар не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при изменении товара в каталоге: {ex.Message}" +
                    $"\n\nСкорее всего Вы не ввели данные в обязательные поля или ввели их неверно.", "Ошибка изменения товара");
            }
        }

        private void ClearFormFields()
        {
            productTitleTextBox.Text = string.Empty;
            productDescriptionTextBox.Text = string.Empty;
            productCostTextBox.Text = string.Empty;
            noRadioButton.IsChecked = false;
            yesRadioButton.IsChecked = false;
            string imagePath = "\\Media\\Icon\\EmptyImage.png";
            BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            imgPhoto.Source = bitmapImage;
        }

        private void buttonSaveChangesOfProduct_onClick(object sender, RoutedEventArgs e)
        {
            Dictionary<string, object> productAttributes = ParseFieldsAndCompleteObject();

            if (productAttributes != null)
            {
                Products product = new Products
                {
                    
                    id = EditableProduct.id, // Устанавливаем ID изменяемого товара
                    title = (string)productAttributes["title"],
                    description = (string)productAttributes["description"],
                    cost = (decimal)productAttributes["cost"],
                    is_available = (bool)productAttributes["is_available"],
                    image = (byte[])productAttributes["image"]
                };
                EditProductToDatabase(product);
            }

            SaveImageToWorkingDirectory();
            
        } 
    }
}