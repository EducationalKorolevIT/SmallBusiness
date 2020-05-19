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
    /// Логика взаимодействия для TasksViewControl.xaml
    /// </summary>
    public partial class TasksViewControl : UserControl
    {
        public TasksViewControl(bool enableDelete)
        {
            InitializeComponent();
            DeleteBtn.IsEnabled = enableDelete;
            TasksGrid.ItemsSource = MainWindow.Database.tasks.ToList();
        }

        private void DeleteTask(object sender, RoutedEventArgs e)
        {
            MainWindow.Database.tasks.Remove((tasks)TasksGrid.SelectedItem);
            MainWindow.Database.SaveChanges();
            TasksGrid.ItemsSource = MainWindow.Database.tasks.ToList();
        }
    }
}
