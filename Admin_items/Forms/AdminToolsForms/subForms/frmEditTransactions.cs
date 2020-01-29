using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_items.AppLayer;
using System.Windows.Forms;

namespace Admin_items.Forms.AdminToolsForms.subForms
{
    public partial class frmEditTransactions : Form
    {
        public Transactions transactions = new Transactions();
        public AppLayer.Reports reports = new AppLayer.Reports();
        public frmEditTransactions()
        {
            InitializeComponent();
        }
        public void Load_Transactions()
        {
           
            lstbxTransID.DataSource = null;
            chklstbxTransactions.DataSource = null;
            lstbxTransID.Items.Clear();
            chklstbxTransactions.Items.Clear();
            var trans =  transactions.Load_Trans_For_Edit();
            lstbxTransID.DataSource = trans.Item1;
            chklstbxTransactions.DataSource = trans.Item2;

        }

        private void frmEditTransactions_Load(object sender, EventArgs e)
        {
            Load_Transactions();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var chkd = chklstbxTransactions.CheckedItems;
           DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete {chkd.Count} record(s)?!\nThis step CANNOT be undone","Confirm Deleting records permanently"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                foreach (var item in chkd)
                {

                    transactions.delete_transactions_perm(lstbxTransID.Items[chklstbxTransactions.Items.IndexOf(item)].ToString());

                }
                Load_Transactions();
                MessageBox.Show("The transactions has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
               
        }
    }
}
