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
    /// Логика взаимодействия для ViewTasksControl.xaml
    /// </summary>
    public partial class ViewTasksControl : UserControl
    {
        public ViewTasksControl(bool enableDelete)
        {
            InitializeComponent();
            deleteBtn.IsEnabled = enableDelete;
            TasksGrid.ItemsSource = MainWindow.Database.tasks_view.ToList();
        }

        private void UpdateTasks(object sender, RoutedEventArgs e)
        {
            TasksGrid.ItemsSource = MainWindow.Database.tasks_view.ToList();
        }

        private void DeleteTask(object sender, RoutedEventArgs e)
        {
            tasks_view sel = TasksGrid.SelectedItem as tasks_view;
            if (sel == null) MessageBox.Show("Выберите задачу для удаления","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            else MainWindow.Database.tasks.Remove(MainWindow.Database.tasks.FirstOrDefault(f=>f.id==sel.id));
            MainWindow.Database.SaveChanges();
            UpdateTasks(null, null);
        }
    }
}
