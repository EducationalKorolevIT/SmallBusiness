using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SmallBusiness.HelpClasses
{
    class Settings
    {
        public static void SaveAccount (string login, string password)
        {
            RegistryKey CurrentUser = Registry.CurrentUser;
            RegistryKey SB = CurrentUser.CreateSubKey("SmallBusiness");
            SB.SetValue("login", login);
            SB.SetValue("password", password);
            SB.Close();
        }

        public static void LoadAccount (ref string login, ref string password)
        {
            RegistryKey CurrentUser = Registry.CurrentUser;
            RegistryKey SB = CurrentUser.OpenSubKey("SmallBusiness");
            login = SB.GetValue("login").ToString();
            password = SB.GetValue("password").ToString();
            SB.Close();
        }
    }
}
