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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class AuthorizationForm : Window
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int userId = -1;
            String userName = LoginField.Text;
            String userPass = PasswordField.Password;
            foreach(users user in MainWindow.Database.users)
            {
                if (user.login == userName && user.password == userPass)
                {
                    userId = user.id;
                }
            }

            if (userId != -1)
            {
                MainWindow.Main.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильное имя или пароль");
            }
        }
    }
}
