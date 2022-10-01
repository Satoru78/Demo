using Microsoft.Win32;
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
using Tkani.Context;
using Tkani.Model;

namespace Tkani.Views.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProductActionPage.xaml
    /// </summary>
    public partial class ProductActionPage : Page
    {
        public Product Product { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public ProductActionPage(Product product)
        {
            InitializeComponent();
            Product = product;
            this.DataContext = this;
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            openFile.Filter = "Image (*.jpeg; *.png *.jpg) | *.png *.jpg *.jpeg";
            if(openFile.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(openFile.FileName));
                Img.Source = image;
            }
        }
        OpenFileDialog openFile = new OpenFileDialog();
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Product.ID == 0)
                {
                    Data.tm.Product.Add(Product);
                }
                File.Copy(openFile.FileName, $"products\\{System.IO.Path.GetFileName(openFile.FileName).Trim()}", true);
                Product.GetImage = "\\products\\" + System.IO.Path.GetFileName(openFile.FileName);
                Data.tm.SaveChanges();
                MessageBox.Show("Данные успешно сохранены", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "произошла ошибка");
            }
        }
    }
}
