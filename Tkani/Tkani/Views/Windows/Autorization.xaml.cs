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
using Tkani.Views.Windows;

namespace Tkani
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            if(txbLogin.Text == "" && txbPassword.Text == "")
            {
                throw new Exception("Заполните все поля");
                   
            }
            else
            {
                var currentUser = Data.tm.User.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Text);
                if(currentUser != null)
                {
                    switch(currentUser.IDRole)
                    {
                        case "1":
                            Admin adminWindow = new Admin();
                            adminWindow.ShowDialog();
                            break;
                        case "2":
                            Manager managerWindow = new Manager();
                            managerWindow.ShowDialog();
                            break;
                    }
                }
                else
                {
                    throw new Exception("Ошибка");
                }
            }

            }
            catch
            {
                MessageBox.Show("ошибка", "ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
