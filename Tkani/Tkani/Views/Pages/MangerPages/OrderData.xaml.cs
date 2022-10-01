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

namespace Tkani.Views.Pages.MangerPages
{
    /// <summary>
    /// Логика взаимодействия для OrderData.xaml
    /// </summary>
    public partial class OrderData : Page
    {
        public OrderStatus OrderStatus { get; set; }
        public List<Order> Orders { get; set; }
        public Order Order { get; set; }
        public OrderData(Order order)
        {
            InitializeComponent();
            Order = order;
            this.DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void txbSerchOrder_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DataOrder.ItemsSource = Data.tm.Order.Where(item => item.Code.ToString().Contains(txbSerchOrder.Text) || item.PointOfIssue.Contains(txbSerchOrder.Text)
            || item.ClientName.Contains(txbSerchOrder.Text)).ToList();
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderAction(new Model.Order()));
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = DataOrder.SelectedItem as Order;
            if (selectedItem != null)
            {
                NavigationService.Navigate(new OrderAction(selectedItem));
            }
        }

        private void btnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = DataOrder.SelectedItem as Order;
            if (selectedItem != null)
            {
                Data.tm.Order.Remove(selectedItem);
                Data.tm.SaveChanges();
            }
                MessageBox.Show("Данные успешно удалены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                Page_Loaded(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Выберите объект из списка!");
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Orders = Data.tm.Order.ToList();
            DataOrder.ItemsSource = Orders;
        }
    }
}
