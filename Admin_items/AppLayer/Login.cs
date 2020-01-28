using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_items.AppLayer
{
    public class Login
    {
        Users users = new Users();
        public user log_user = new user();

        public Tuple<bool, user>  LoggedUser(string username, string pw)
        {
            username = username.ToLower();
            var logged_user = users.Get_User_By_Name(username);
            if (logged_user is null)
            {
                System.Windows.Forms.MessageBox.Show("User Cannot be found","User Name Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                return Tuple.Create<bool, user>(false, null);
            }
            else if (logged_user.user_name==username & logged_user.password==users.pw_hasing(pw))
            {
                log_user = logged_user;
                return Tuple.Create<bool, user>(true,log_user);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Password is incorrect","Password Error",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return Tuple.Create<bool, user>(false, null);
            }
        }

    }
}
