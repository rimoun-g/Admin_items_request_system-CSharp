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
using Admin_items.AppLayer;
using Admin_items.Forms.Login;
using Admin_items.Forms.Reports;
using DataLayer.Models;

namespace Admin_items.Forms
{
    public partial class frmMainPanel : Form
    {
        public int UserID { get; set; }

        public user Current_User = new user();
        public frmMainPanel()
        {
            InitializeComponent();
        }
        private void btnAddTransactionsForm_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            frmTransactions.Current_user = Current_User;
            frmTransactions.ShowDialog();
        }

        private void btnAdminToolsForm_Click(object sender, EventArgs e)
        {
            if (Current_User.level == 1)
            {
                frmAdministratorTools frmAdministratorTools = new frmAdministratorTools();
                frmAdministratorTools.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have enough privileges", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void frmMainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainPanel_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "User: " +Current_User.user_name.ToUpper();
            if (Current_User.level ==1 )
            {
                btnAdminToolsForm.Enabled = true;
            }
            else
            {
                btnAdminToolsForm.Enabled = false;
            }
        }

        private void btnReportsForm_Click(object sender, EventArgs e)
        {
            frmCustomizedReport customizedReport = new frmCustomizedReport();
            customizedReport.ShowDialog();
        }

        private void btnAddEmployeeExternal_Click(object sender, EventArgs e)
        {

            AdminToolsForms.subForms.frmEmployees  employees = new AdminToolsForms.subForms.frmEmployees();
            employees.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This applications was programmed by Rimoun George\nTranslator @ HR & Admin Department - AP","About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
