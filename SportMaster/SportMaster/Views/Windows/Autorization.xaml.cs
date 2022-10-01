using SportMaster.Context;
using SportMaster.Model;
using SportMaster.Views.Windows;
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

namespace SportMaster
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
               if(txbPassword.Text == "" && txbLogin.Text == "")
                {
                    throw new Exception("Заполните все поля!");
                }
               else
                {
                    var currentUser = Data.sm.User.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Text);
                    if (currentUser != null)
                    {
                        switch (currentUser.IDRole)
                        {
                            case 1:
                                AdminWindow adminWindow = new AdminWindow();
                                adminWindow.ShowDialog();
                                break;
                            case 2:
                                ManagerWindow managerWindow = new ManagerWindow();
                                managerWindow.ShowDialog();
                                break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
