using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace SmallBusiness
{
    /// <summary>
    /// Логика взаимодействия для ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        public ViewWindow()
        {
            InitializeComponent();
            MainWindow.Database.ProductView.Load();
            DatabaseGrid.ItemsSource = MainWindow.Database.ProductView.Local.ToBindingList();
        }

        ProductAdd prAddWin;
        Window1 editWin;

        private void AddProd(object sender, RoutedEventArgs e)
        {
            prAddWin = new ProductAdd();
            prAddWin.Show();
        }

        private void DeleteProd(object sender, RoutedEventArgs e)
        {
            ProductView p = (ProductView)(DatabaseGrid.SelectedItem);
            int id = p.id;
            MainWindow.Database.TablePrice.Remove(MainWindow.Database.TablePrice.FirstOrDefault(f => f.id_product == id));
            MainWindow.Database.TableProduct.Remove(MainWindow.Database.TableProduct.FirstOrDefault(f => f.id == id));
            MainWindow.Database.SaveChanges();
        }

        private void EditProd(object sender, RoutedEventArgs e)
        {
            ProductView p = (ProductView)(DatabaseGrid.SelectedItem);
            int id = p.id;
            editWin = new Window1(id);
            editWin.Show();
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateBtnClick(object sender, RoutedEventArgs e)
        {
            DatabaseGrid.ItemsSource = null;
            DatabaseGrid.Items.Clear();
            DatabaseGrid.ItemsSource = MainWindow.Database.ProductView.Local.ToBindingList();
        }
    }
}
