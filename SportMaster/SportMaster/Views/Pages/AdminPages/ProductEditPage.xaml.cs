using Microsoft.Win32;
using SportMaster.Context;
using SportMaster.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace SportMaster.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProductEditPage.xaml
    /// </summary>
    public partial class ProductEditPage : Page
    {
        
        public Product Product { get; set; }
        public List<ProductCategory> ProductCategorys { get; set; }
        public ProductEditPage(Product product)
        {
            InitializeComponent();
            Product = product;
            ProductCategorys = Data.sm.ProductCategory.ToList();
            this.DataContext = this;
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            open.Filter = "Image (*.jpeg; *.png; *.jpg;) | *.jpeg;* .png; *.jpg";
            if (open.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(open.FileName));
                Img.Source = image;
         
            }

        }
        OpenFileDialog open = new OpenFileDialog();
        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Product.ID == 0)
                {
                    Data.sm.Product.Add(Product);
                }
                File.Copy(open.FileName, $"products\\{System.IO.Path.GetFileName(open.FileName).Trim()}", true);
                Product.GetImage = "\\products\\" + System.IO.Path.GetFileName(open.FileName);
                Data.sm.SaveChanges();
                MessageBox.Show("Данные сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("Произошла неизвестная ошибка , проверьте заполнены ли все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
