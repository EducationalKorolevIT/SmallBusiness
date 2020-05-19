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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmallBusiness.Forms.SubForms
{
    /// <summary>
    /// Логика взаимодействия для ViewControl.xaml
    /// </summary>
    public partial class ViewControl : UserControl
    {
        public static ViewControl self;
        public ViewControl()
        {
            InitializeComponent();
            MainWindow.Database.producttable.Load();
            UpdateBtnClick(null, null);
            self = this;
        }

        private void DeleteProd(object sender, RoutedEventArgs e)
        {
            try
            {
                producttable p = (producttable)(DatabaseGrid.SelectedItem);
                MainWindow.Database.producttable.Remove(p);
                MainWindow.Database.SaveChanges();
                UpdateBtnClick(null, null);
            }
            catch (Exception ex) { MessageBox.Show("Выберите элемент для удаления","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void EditProd(object sender, RoutedEventArgs e)
        {
            try
            {
                producttable p = (producttable)(DatabaseGrid.SelectedItem);
                StackPanel element = new StackPanel();
                EditControl edit = new EditControl(p);
                element.Orientation = Orientation.Horizontal;

                element.Children.Add(new TextBlock()
                {
                    Text = "Добавление товара "
                });


                Button btn = new Button();
                btn.Click += ((MainWindow)((Grid)((TabControl)((TabItem)Parent).Parent).Parent).Parent).deleteBtnClk;
                btn.Content = "✕";
                btn.Background = Brushes.Transparent;
                btn.BorderThickness = new Thickness(0);


                element.Children.Add(btn);
                TabItem item = new TabItem()
                {
                    Content = edit,
                    Header = element
                };
                MainWindow.Main.ControlView.Items.Add(item);
                MainWindow.Main.ControlView.SelectedItem = item;
            }
            catch (Exception ex) { MessageBox.Show("Выберите элемент для редактирования", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        public void UpdateBtnClick(object sender, RoutedEventArgs e)
        {
            DatabaseGrid.ItemsSource = MainWindow.Database.producttable.ToList();
        }
    }
}
