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
using System.Windows.Shapes;

namespace SmallBusiness
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int id;
        public Window1(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void SaveToDatabase(object sender, RoutedEventArgs e)
        {
            String name = NameField.Text;
            String article = ArticleField.Text;
            String descr = DescField.Text;
            String manufacturer = ManufacturerField.Text;
            int price = Convert.ToInt32(PriceField.Text);

            producttable prod = MainWindow.Database.producttable.FirstOrDefault(f => f.id == id);

            prod.Name = name;
            prod.Article = article;
            prod.Description = descr;
            prod.Manufacturer = manufacturer;

            //MainWindow.Database.TablePrice.FirstOrDefault(f=>f.id_product==prod.id).Price = price;

            MainWindow.Database.SaveChanges();
        }
    }
}
