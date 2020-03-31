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
        public static SmallBusinessEntities Database = new SmallBusinessEntities();
        public static MainWindow Main;
        public MainWindow()
        {
            InitializeComponent();
            Main = this;
            Hide();
            Window2 win = new Window2();
            win.Show();
        }
    }
}
