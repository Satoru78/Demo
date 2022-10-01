using StroyMaterial.Context;
//using StroyMaterial.Model;
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

namespace StroyMaterial.Views.Pages.ManagerPages
{
	/// <summary>
	/// Логика взаимодействия для OrderPage.xaml
	/// </summary>
	public partial class OrderPage : Page
	{
		//public Order Order { get; set; }
		public OrderPage()
		{
			InitializeComponent();
		}

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void txbSearchOrder_SelectionChanged(object sender, RoutedEventArgs e)
		{

		}

		private void cmbOrderStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void btnAddOrder_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnEditOrder_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDeleteOrder_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			OrderData.ItemsSource = Data.str.Order.ToList();
		}
	}
}
