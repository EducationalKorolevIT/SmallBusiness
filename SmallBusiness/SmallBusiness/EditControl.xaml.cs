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
    /// Логика взаимодействия для EditControl.xaml
    /// </summary>
    public partial class EditControl : UserControl
    {
        int id;
        public EditControl(producttable ent)
        {
            InitializeComponent();
            this.id = ent.id;
            NameField.Text = ent.Name;
            ArticleField.Text = ent.Article;
            DescField.Text = ent.Description;
            ManufacturerField.Text = ent.Manufacturer;
            PriceField.Text = Convert.ToString(ent.Price);
        }

        private void SaveToDatabase(object sender, RoutedEventArgs e)
        {
            String name = NameField.Text;
            String article = ArticleField.Text;
            String descr = DescField.Text;
            String manufacturer = ManufacturerField.Text;
            float price = Convert.ToSingle(PriceField.Text);

            producttable prod = MainWindow.Database.producttable.FirstOrDefault(f => f.id == id);

            prod.Name = name;
            prod.Article = article;
            prod.Description = descr;
            prod.Manufacturer = manufacturer;
            prod.Price = price;

            MainWindow.Database.SaveChanges();

            ViewWindow.self.UpdateBtnClick(null, null);
        }
    }
}
