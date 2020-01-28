using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.AppLayer;
using DataLayer.Models;

namespace Admin_items.Forms.AdminToolsForms.subForms
{
    public partial class frmUsers : Form
    {
        Users users = new Users();
        user inv_user = new user();
        public frmUsers()
        {
            InitializeComponent();
            btnAddUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            btnUpdateUser.Enabled = false;
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

            var chk_usr = users.check_username_exists(txtUserName.Text);
                if (chk_usr.Item1)
            {
                btnDeleteUser.Enabled = true;
                btnUpdateUser.Enabled = true;
                btnAddUser.Enabled = false;
                inv_user = chk_usr.Item2;
                cmbxLevel.SelectedItem = chk_usr.Item2.level.ToString();
            }
            else
            {
                btnDeleteUser.Enabled = false;
                btnUpdateUser.Enabled = false;
                btnAddUser.Enabled = true;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
             users.Add_New_User(txtUserName.Text, txtPw.Text, txtRePw.Text, cmbxLevel.Text);
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44)
            {
                e.Handled = true;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            user updated_user = new user();
            updated_user.id = inv_user.id;
            updated_user.level = int.Parse(cmbxLevel.Text);
            updated_user.user_name = txtUserName.Text;
            users.Update_User (updated_user, txtPw.Text, txtRePw.Text);
        }
    }
}
