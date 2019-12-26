using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.Forms.AdminToolsForms;
using Admin_items.Forms.DataEntry;

namespace Admin_items.Forms
{
    public partial class frmMainPanel : Form
    {
        public frmMainPanel()
        {
            InitializeComponent();
        }

        private void btnAddTransactionsForm_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.ShowDialog();
        }

        private void btnAdminToolsForm_Click(object sender, EventArgs e)
        {
            frmAdministratorTools frmAdministratorTools = new frmAdministratorTools();
            frmAdministratorTools.ShowDialog();
        }

        private void frmMainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
