﻿using SmallBusiness.Forms.SubForms;
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
    /// Логика взаимодействия для AddControl.xaml
    /// </summary>
    public partial class AddControl : UserControl
    {
        public AddControl()
        {
            InitializeComponent();
        }

        private void AddProdItem(object sender, RoutedEventArgs e)
        {
            try
            {
                String pName = NameField.Text;
                String pArticle = ArticleField.Text;
                String pManufacturer = ManufacturerField.Text;
                String pDesc = DescriptionField.Text;
                String pUPP = UPPField.Text;
                String pUTP = UnitTypeField.Text;
                int pPrice = Convert.ToInt32(PriceField.Text);
                producttable pItem = new producttable()
                {
                    Article = pArticle,
                    Name = pName,
                    Manufacturer = pManufacturer,
                    Description = pDesc,
                    UnitPerPrice = Convert.ToSingle(pUPP),
                    UnitType = pUTP,
                    Price = pPrice
                };

                producttable fItem = MainWindow.Database.producttable.FirstOrDefault(f => f.Name == pName && f.Description == pDesc && f.Article == pArticle && f.Manufacturer == pManufacturer);

                if (fItem == null)
                {
                    MainWindow.Database.producttable.Add(pItem);
                    fItem = pItem;
                }
                MainWindow.Database.SaveChanges();
                if(ViewControl.self!=null)ViewControl.self.UpdateBtnClick(null, null);
            }
            catch (Exception ex) { }
        }
    }
}
