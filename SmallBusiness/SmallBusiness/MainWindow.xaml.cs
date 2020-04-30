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
            TabItem item = new TabItem()
            {
                Content = add,
                Header = "Добавление"
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }

        private void ViewProducts(object sender, RoutedEventArgs e)
        {
            ViewControl view = new ViewControl();
            TabItem item = new TabItem()
            {
                Content = view,
                Header = "Просмотр товаров"
            };
            ControlView.Items.Add(item);
            ControlView.SelectedItem = item;
        }
    }
}
