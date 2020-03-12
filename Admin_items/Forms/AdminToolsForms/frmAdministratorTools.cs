using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.Forms.AdminToolsForms.subForms;

namespace Admin_items.Forms
{
    public partial class frmAdministratorTools : Form
    {
        public frmAdministratorTools()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            frmItems frmItems = new frmItems();
            frmItems.ShowDialog();
        }

        private void btnSubcats_Click(object sender, EventArgs e)
        {
            frmSubcat frmSubcat = new frmSubcat();
            frmSubcat.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void btnEditTransactions_Click(object sender, EventArgs e)
        {
            frmEditTransactions EditTransations = new frmEditTransactions();
            EditTransations.ShowDialog();
        }
    }
}
