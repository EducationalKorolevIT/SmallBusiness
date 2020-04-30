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
        public MainWindow()
        {
            InitializeComponent();
            Main = this;
            Hide();
            AuthorizationForm win = new AuthorizationForm();
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

        void deleteBtnClk(object sender, RoutedEventArgs e)
        {
            ControlView.Items.Remove(((FrameworkElement)((FrameworkElement)sender).Parent).Parent);
        }
    }
}
