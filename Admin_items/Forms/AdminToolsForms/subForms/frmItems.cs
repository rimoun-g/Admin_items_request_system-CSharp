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
    public partial class frmItems : Form
    {
        Items items = new Items();
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            items.add_item(txtAddItem.Text);
            FillComboBox();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            var all_items = items.GetllALLITEMS();
            if (all_items.Count() > 0)
            {
                cmbxDeleteItem.DataSource = all_items;
            }
        }

        private void cmbxDeleteItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
