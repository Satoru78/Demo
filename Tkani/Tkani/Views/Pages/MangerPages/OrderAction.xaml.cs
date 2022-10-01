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
    /// Логика взаимодействия для OrderAction.xaml
    /// </summary>
    public partial class OrderAction : Page
    {
        public Order Order { get; set; }
        public List<OrderStatus> OrderStatuses { get; set; }
        public OrderAction(Order order)
        {
            InitializeComponent();
            Order = order;
            OrderStatuses = Data.tm.OrderStatus.ToList();
            this.DataContext = this;

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            if(Order.ID == 0)
            {
                Data.tm.Order.Add(Order);
                Data.tm.SaveChanges();
            }
            MessageBox.Show("Данные успешно сохранены", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();

            }
            catch/*(Exception ex)*/
            {
                //MessageBox.Show(ex.Message , "Проверьте , заполнены ли все стобцы");
                MessageBox.Show("Произошла неизвестная ошибка , проверьте заполнены ли все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
