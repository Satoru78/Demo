using SportMaster.Context;
using SportMaster.Model;
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

namespace SportMaster.Views.Pages.ManagerPages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    /// 

    
    public partial class OrderPage : Page
    {
        public OrderStatus OrderStatus { get; set; }
        public Order Order { get; set; }
        public OrderPage(Order order)
        {
            InitializeComponent();
            Order = order;
            this.DataContext = this;
        }

        private void OrderTxb_SelectionChanged(object sender, RoutedEventArgs e)
        {
            OrderData.ItemsSource = Data.sm.Order.Where(item => item.ClientName.Contains(OrderTxb.Text) || item.Code.ToString().Contains(OrderTxb.Text)).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OrderData.ItemsSource = Data.sm.Order.ToList();
        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderActionPage( new Model.Order()));
        }

        private void EditOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Order)OrderData.SelectedItem;
            if(selectedItem != null)
            {
                NavigationService.Navigate(new OrderActionPage(selectedItem));
            }
        }

        private void DeleteBtnOrder_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Order)OrderData.SelectedItem;
            if(selectedItem != null)
            {
                Data.sm.Order.Remove(selectedItem);
                Data.sm.SaveChanges();
                Page_Loaded(null, null);
            }
            MessageBox.Show("Данные удалены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SearchStatus((cmbStatus.SelectedItem as ComboBoxItem).Content.ToString());
        }

        private void SearchStatus (string type = "" )
        {
            var orders = Data.sm.Order.ToList();
            if(!string.IsNullOrEmpty(type) && !string.IsNullOrEmpty(type))
            {
                if(type == "Новый")
                {
                    orders = orders.Where(item => OrderStatus.Title == "Новый").ToList();
                }
                OrderData.ItemsSource = orders;
            }
        }
    }
}
