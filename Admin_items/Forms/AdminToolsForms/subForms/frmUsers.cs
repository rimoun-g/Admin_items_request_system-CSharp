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

namespace Admin_items.Forms.AdminToolsForms.subForms
{
    public partial class frmUsers : Form
    {
        Users users = new Users();
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
                if (chk_usr)
            {
                btnDeleteUser.Enabled = true;
                btnUpdateUser.Enabled = true;
                btnAddUser.Enabled = false;
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
             users.Add_New_User(txtUserName.Text, txtPw.Text, txtRePw.Text, txtUserLevel.Text);
        }
    }
}
