using DataLayer.code;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_items.AppLayer
{
    public class Users
    {
        user_code user_Code = new user_code();

       
        public void Add_New_User(string user_name, string pw, string repw , string lv)
        {
            int.TryParse(lv, out int level);


            if (!string.IsNullOrEmpty(user_name) & !string.IsNullOrEmpty(pw) & (level > 0 & level < 4) & (pw == repw))
            {
                if (!check_username_exists(user_name))
                {
                    user_Code.add_user(user_name.ToLower(), pw, level);
                    MessageBox.Show("The user has been added successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This username is already taken, please try another one","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check the password & level fields again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<user> Get_All_Users()
        {
            var users = user_Code.GetAllUsers();

            return users;
        }
        public bool check_username_exists(string username)
        {
            var usrs = Get_All_Users();
            foreach (var usr in usrs)
            {
                if (usr.user_name == username.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public user Get_User_By_Name(string username)
        {
            var usr = user_Code.GetUserByName(username);

            return usr;
        }
        public string pw_hasing(string pw)
        {
           return user_Code.sha256(pw);
        }
    }
}
