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
using Tkani.Context;
using Tkani.Model;

namespace Tkani.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProductDataPage.xaml
    /// </summary>
    public partial class ProductDataPage : Page
    {
        public ProductCategory ProductCategory { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
        public ProductDataPage(Product product)
        {
            InitializeComponent();
            Product = product;
            this.DataContext = this;
        }

        private void txbSearchProduct_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ListProduct.ItemsSource = Data.tm.Product.Where(item => item.Count.ToString().Contains(txbSearchProduct.Text) ||
            item.Title.Contains(txbSearchProduct.Text) || item.Manufacturer.Contains(txbSearchProduct.Text)).ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductActionPage(new Model.Product()));
        }

        private void EditProductBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ListProduct.SelectedItem as Product;
            if (selectedItem != null)
            {
                 NavigationService.Navigate(new ProductActionPage(new Model.Product()));
            }
        }

        private void DeleteProducBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ListProduct.SelectedItem as Product;
            if(selectedItem != null)
            {
                Data.tm.Product.Remove(selectedItem);
                Data.tm.SaveChanges();

            }
            MessageBox.Show("данные удалены" , "успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                Page_Loaded(null, null);
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Products = Data.tm.Product.ToList();
            ListProduct.ItemsSource = Products;
        }
    }
}
