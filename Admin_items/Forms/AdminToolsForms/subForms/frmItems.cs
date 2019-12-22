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
            var all_items = items.Items_Names();
            if (all_items is null == false)
            {
                cmbxDeleteItem.DataSource = all_items;
            }
        }

        private void cmbxDeleteItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDeleteItem.Text != "")
            {

                item curr_item = items.item_by_name(cmbxDeleteItem.Text);

                if (curr_item.is_active == 1)
                {
                    btnDeleteItem.Enabled = true;
                    btnUndeleteItem.Enabled = false;
                }
                else
                {
                    btnUndeleteItem.Enabled = true;
                    btnDeleteItem.Enabled = false;
                }

            }


        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            item curr_item = items.item_by_name(cmbxDeleteItem.Text);
            items.UpdateItem(curr_item);
            FillComboBox();
            
        }

        private void btnUndeleteItem_Click(object sender, EventArgs e)
        {
            item curr_item = items.item_by_name(cmbxDeleteItem.Text);
            items.UndoUpdateItem(curr_item);
            FillComboBox();
            
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            item curr_item = items.item_by_name(cmbxDeleteItem.Text);
            items.UpdateItemName(curr_item, txtUpdateItem.Text);
            FillComboBox();
        }
    }
}
