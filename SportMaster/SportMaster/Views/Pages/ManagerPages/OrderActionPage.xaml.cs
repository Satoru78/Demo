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
using SportMaster.Context;
using SportMaster.Model;

namespace SportMaster.Views.Pages.ManagerPages
{
    /// <summary>
    /// Логика взаимодействия для OrderActionPage.xaml
    /// </summary>
    /// 
    public partial class OrderActionPage : Page
    {
        public Order Order { get; set; }
        public List<OrderStatus> OrderStatuses { get; set; }
        public OrderActionPage(Order order)
        {
            InitializeComponent();
            Order = order;
            OrderStatuses = Data.sm.OrderStatus.ToList();
            this.DataContext = this;
        }

        private void TxbSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            if (Order.ID == 0)
            {
                Data.sm.Order.Add(Order);
                Data.sm.SaveChanges();
            }
            MessageBox.Show("Данные сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Произошла неизвестная ошибка , проверьте заполнены ли все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
