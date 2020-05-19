using Org.BouncyCastle.Bcpg;
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
    /// Логика взаимодействия для AddTaskControl.xaml
    /// </summary>
    public partial class AddTaskControl : UserControl
    {
        public TabItem itemToDelete;
        public AddTaskControl()
        {
            InitializeComponent();
            string[] users = new string[MainWindow.Database.users.Count()];
            for(int i = 0; i < users.Length; i++)
            {
                users[i] = MainWindow.Database.users.ToList().ElementAt(i).login;
            }
            UsersComboBox.ItemsSource = users;
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            String taskText = TaskField.Text;
            String taskTheme = TaskThemeField.Text;
            String taskToUser = (string)UsersComboBox.SelectedValue;
            tasks t = new tasks() { TaskText = taskText, TaskTheme=taskTheme, users=MainWindow.Database.users.FirstOrDefault(f=>f.login==taskToUser)};
            tasks ct = MainWindow.Database.tasks.FirstOrDefault(f => f.TaskText == taskText);
            if (ct == null)
            {
                MainWindow.Database.tasks.Add(t);
            }
            MainWindow.Database.SaveChanges();
            MainWindow.Main.ControlView.Items.Remove(itemToDelete);
        }
    }
}
