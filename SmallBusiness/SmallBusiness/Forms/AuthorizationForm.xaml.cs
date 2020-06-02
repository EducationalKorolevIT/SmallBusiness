using SmallBusiness.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        Timer tmr;
        public AuthorizationForm()
        {
            InitializeComponent();
            bool ischk=false;
            string s1="", s2="";
            Settings.LoadAccount(ref s1, ref s2, ref ischk);
            SaveLP.IsChecked = ischk;
            if (ischk)
            {
                LoginField.Text = s1;
                PasswordField.Password = s2;
            }
        }
        bool isClosedAuto = false;
        private void Button_Click(object sender, EventArgs e)
        {
            //tmr.Stop();
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
                MainWindow.Main.havePermission = MainWindow.Database.users.FirstOrDefault(f => f.id == userId).userType==1;
                Settings.SaveAccount(userName, userPass, (bool)SaveLP.IsChecked);
                MainWindow.Main.updatePermissions();
            }
            else
            {
                MessageBox.Show("Неправильное имя или пароль");
            }

            if (userId != -1)
            {
                isClosedAuto = true;
                Close();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!isClosedAuto)
            {
                MainWindow.Main.Close();
                Close();
            }
        }
    }
}
