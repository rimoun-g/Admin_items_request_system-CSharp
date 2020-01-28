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
        public frmEditTransactions()
        {
            InitializeComponent();
        }
        public void Load_Transactions()
        {
            lstbxTransID.Items.Clear();
            chklstbxTransactions.Items.Clear();
           
            var trans = transactions.GellAllEmpTrans();
            foreach (var item in trans)
            {
                lstbxTransID.Items.Add(item.id);
                chklstbxTransactions.Items.Add(item.id + " - " +item.unit_price + " - " + item.quantity + " - " + item.remarks + " - " + item.delivery_date + " - " + item.emp_no);
            }

        }

        private void frmEditTransactions_Load(object sender, EventArgs e)
        {
            Load_Transactions();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var chkd = chklstbxTransactions.CheckedItems;
                foreach (var item in chkd)
            {
                
                transactions.delete_transactions_perm(lstbxTransID.Items[chklstbxTransactions.Items.IndexOf(item)].ToString());
                
            }
            MessageBox.Show("The transactions has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_Transactions();
        }
    }
}
