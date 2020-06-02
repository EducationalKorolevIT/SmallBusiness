using SmallBusiness.Forms.SubForms;
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

namespace SmallBusiness
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static smallbusinessEntities Database = new smallbusinessEntities();
        public static MainWindow Main;
        public bool havePermission = false;
        AuthorizationForm win;
        public MainWindow()
        {
            InitializeComponent();
            Main = this;
            Hide();
            win = new AuthorizationForm();
            win.Show();
        }

        private void AddProducts(object sender, RoutedEventArgs e)
        {
            AddControl add = new AddControl();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text="Добавление товара "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }

        private void ViewProducts(object sender, RoutedEventArgs e)
        {
            ViewControl view = new ViewControl();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Просмотр товара "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = view,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }

        public void updatePermissions()
        {
            AddTaskItem.IsEnabled = havePermission;
        }

        public void deleteBtnClk(object sender, RoutedEventArgs e)
        {
            ControlView.Items.Remove(((FrameworkElement)((FrameworkElement)sender).Parent).Parent);
        }

        private void ViewTasks(object sender, RoutedEventArgs e)
        {
            ViewTasksControl add = new ViewTasksControl(havePermission);
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Просмотр задач "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            AddTaskControl add = new AddTaskControl();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Добавление задачи "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
            add.itemToDelete = item;
        }

        private void AddToWarehouse(object sender, RoutedEventArgs e)
        {
            AddToWarehouseControl add = new AddToWarehouseControl();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Добавление на склад "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
            add.itemToDelete = item;
        }

        private void ViewWarehouse(object sender, RoutedEventArgs e)
        {
            WarehouseView add = new WarehouseView();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Просмотр склада "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
            add.itemToDelete = item;
        }

        private void ViewAutors(object sender, RoutedEventArgs e)
        {
            ViewAutors add = new ViewAutors();
            StackPanel element = new StackPanel();
            element.Orientation = Orientation.Horizontal;

            element.Children.Add(new TextBlock()
            {
                Text = "Авторы проекта "
            });


            Button btn = new Button();
            btn.Click += deleteBtnClk;
            btn.Content = "✕";
            btn.Background = Brushes.Transparent;
            btn.BorderThickness = new Thickness(0);


            element.Children.Add(btn);
            TabItem item = new TabItem()
            {
                Content = add,
                Header = element
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }
    }
}
