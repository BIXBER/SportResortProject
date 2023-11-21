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

        public MainPage()
        {
            InitializeComponent();
            using (var dbContext = new SportStoreEntities())
            {
                IControlProductsList.ItemsSource = dbContext.Products.ToList();
            }
        }
    }

    
}
