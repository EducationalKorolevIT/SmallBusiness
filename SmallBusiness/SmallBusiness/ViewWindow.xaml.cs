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
        public static ViewWindow self;
        public ViewWindow()
        {
            InitializeComponent();
            self = this;
        }

        private void AddProd(object sender, RoutedEventArgs e)
        {
            AddControl add = new AddControl();
            TabItem item = new TabItem()
            {
                Content = add,
                Header = "Добавление"
            };
            Tabs.Items.Add(item);
            Tabs.SelectedItem = item;
        }

        private void DeleteProd(object sender, RoutedEventArgs e)
        {
            producttable p = (producttable)(DatabaseGrid.SelectedItem);
            MainWindow.Database.producttable.Remove(p);
            MainWindow.Database.SaveChanges();
            ViewWindow.self.UpdateBtnClick(null, null);
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
            Tabs.Items.Add(item);
            Tabs.SelectedItem = item;
        }

        private void BackBtnClick(object sender, RoutedEventArgs e)
        {

        }

        public void UpdateBtnClick(object sender, RoutedEventArgs e)
        {
            DatabaseGrid.ItemsSource = MainWindow.Database.producttable.ToList();
        }

        private void CloseTab(object sender, RoutedEventArgs e)
        {
            Tabs.Items.Remove(Tabs.SelectedItem);
        }

        private void ViewProds(object sender, RoutedEventArgs e)
        {

        }
    }
}
