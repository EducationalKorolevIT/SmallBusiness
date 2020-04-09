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

        }

        private void EditProd(object sender, RoutedEventArgs e)
        {
            int id = DatabaseGrid.SelectedIndex;
            //MessageBox.Show("Selected ID: " + id);
            editWin = new Window1(id);
            editWin.Show();
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
