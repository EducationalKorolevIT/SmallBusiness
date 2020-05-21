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
    /// Логика взаимодействия для WarehouseView.xaml
    /// </summary>
    public partial class WarehouseView : UserControl
    {
        public TabItem itemToDelete;
        public WarehouseView()
        {
            InitializeComponent();
            WarehouseDataGrid.ItemsSource = MainWindow.Database.warehouse_view.ToList();
        }
    }
}
