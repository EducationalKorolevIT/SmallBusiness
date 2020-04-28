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

namespace SmallBusiness
{
    /// <summary>
    /// Логика взаимодействия для ViewControl.xaml
    /// </summary>
    public partial class ViewControl : UserControl
    {
        public ViewControl()
        {
            InitializeComponent();
            MainWindow.Database.producttable.Load();
            DGrid.ItemsSource = MainWindow.Database.producttable.ToList();
        }
    }
}
