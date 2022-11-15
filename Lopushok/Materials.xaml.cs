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
    /// Логика взаимодействия для Materials.xaml
    /// </summary>
    public partial class Materials : Page
    {
        private CheckUsers MaterialsUser_;
        public Materials(CheckUsers user)
        {
            InitializeComponent();
            MaterialsUser_ = user;
            buttonAdd.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            DataGridCollumnEdit.Visibility = Visibility.Hidden;
            if (MaterialsUser_.isAdmin == true)
            {
                buttonAdd.Visibility = Visibility.Visible;
                buttonDelete.Visibility = Visibility.Visible;
                DataGridCollumnEdit.Visibility = Visibility.Visible;
            }
            dataGridSupplier.ItemsSource = Lopuh.GetContext().Материал.ToList();
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MaterialsAddPage((sender as Button).DataContext as Материал));
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MaterialsAddPage(null));
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var SupplierForRemoving = dataGridSupplier.SelectedItems.Cast<Материал>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {SupplierForRemoving.Count()} элементов?", "Внимание",
               MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Lopuh.GetContext().Материал.RemoveRange(SupplierForRemoving);
                    Lopuh.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    dataGridSupplier.ItemsSource = Lopuh.GetContext().Материал.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        private void Page_IsVisibleChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Lopuh.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dataGridSupplier.ItemsSource = Lopuh.GetContext().Материал.ToList();
            }
        }
    }
}
