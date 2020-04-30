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

namespace SmallBusiness.Forms.SubForms
{
    /// <summary>
    /// Логика взаимодействия для ViewControl.xaml
    /// </summary>
    public partial class ViewControl : UserControl
    {
        public ViewControl()
        {
            InitializeComponent();
        }

        private void DeleteProd(object sender, RoutedEventArgs e)
        {
            producttable p = (producttable)(DatabaseGrid.SelectedItem);
            MainWindow.Database.producttable.Remove(p);
            MainWindow.Database.SaveChanges();
            //ViewWindow.self.UpdateBtnClick(null, null);
        }

        private void EditProd(object sender, RoutedEventArgs e)
        {
            producttable p = (producttable)(DatabaseGrid.SelectedItem);
            EditControl add = new EditControl(p);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = "Редактирование"
            };
            MainWindow.Main.ControlView.Items.Add(item);
            MainWindow.Main.ControlView.SelectedItem = item;
        }

        public void UpdateBtnClick(object sender, RoutedEventArgs e)
        {
            DatabaseGrid.ItemsSource = MainWindow.Database.producttable.ToList();
        }
    }
}
