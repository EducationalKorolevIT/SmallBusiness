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
    /// Логика взаимодействия для ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void AddProdItem(object sender, RoutedEventArgs e)
        {
            String pName = NameField.Text;
            String pArticle = ArticleField.Text;
            String pManufacturer = ManufacturerField.Text;
            String pDesc = DescriptionField.Text;
            int pPrice = Convert.ToInt32(PriceField.Text);
            producttable pItem = new producttable()
            {
                Article = pArticle,
                Name = pName,
                Manufacturer = pManufacturer,
                Description = pDesc,
                Price = pPrice
            };

            producttable fItem = MainWindow.Database.producttable.FirstOrDefault(f => f.Name == pName && f.Description == pDesc && f.Article == pArticle && f.Manufacturer == pManufacturer);

            if (fItem == null)
            {
                MainWindow.Database.producttable.Add(pItem);
                fItem = pItem;
            }
            MainWindow.Database.SaveChanges();

            ViewWindow.self.UpdateBtnClick(null, null);
            Close();
        }
    }
}
