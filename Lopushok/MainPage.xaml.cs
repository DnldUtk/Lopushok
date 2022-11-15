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

namespace Lopushok
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private CheckUsers _user;
        public MainPage(CheckUsers user)
        {
            InitializeComponent();
            _user = user;
            statusTB.Text = "";
            if (_user.StatusAdmin == "Admin")
            {
                statusTB.Text = "Admin";
            }
            else 
            {
                if (_user.StatusMaster == "Master")
                {
                statusTB.Text = "Master";
                }
                else { statusTB.Text = "User"; }
            }
            
        }
        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Product());
        }

        private void Supplier_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Materials(_user));
        }

        private void Master_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MasterPage(_user));
        }
    }
}
