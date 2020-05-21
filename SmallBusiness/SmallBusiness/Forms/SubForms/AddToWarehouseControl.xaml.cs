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
    /// Логика взаимодействия для AddToWarehouseControl.xaml
    /// </summary>
    public partial class AddToWarehouseControl : UserControl
    {
        public TabItem itemToDelete;
        List<producttable> table=new List<producttable>();
        public AddToWarehouseControl()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            table.AddRange(MainWindow.Database.producttable.ToList());
            foreach(producttable p in table)
            {
                names.Add(p.Name);
            }
            ProductsBox.ItemsSource = names;
        }

        private void AddToWarehouse(object sender, RoutedEventArgs e)
        {
            producttable prod = table.FirstOrDefault(f => f.Name == (string)ProductsBox.SelectedValue);
            int quantity = Convert.ToInt32(QuantityField.Text);
            warehouse whItem = new warehouse() { producttable = prod, Quantity = quantity };
            warehouse exItem = MainWindow.Database.warehouse.FirstOrDefault(f => f.id_product == prod.id);
            if (exItem == null)
            {
                MainWindow.Database.warehouse.Add(whItem);
                MainWindow.Database.SaveChanges();
            }
        }
    }
}
