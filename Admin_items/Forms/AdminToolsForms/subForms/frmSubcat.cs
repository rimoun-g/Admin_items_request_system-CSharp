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
    public partial class frmSubcat : Form
    {
        SubCats subCats = new SubCats();

        subcat current_choice;
        public frmSubcat()
        {
            InitializeComponent();
            FillItemsComboBox();
        }


        public void FillItemsComboBox()
        {
            var all_items = subCats.Items_names();
            if (all_items is null == false)
            {
                cmbxItems.DataSource = all_items;
            }
        }

        private void cmbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxItems.Text != "")
            {

                item curr_item = subCats.get_item_by_name(cmbxItems.Text);

                var item_subcats = subCats.GetItemSubCat(curr_item.id);
                if (item_subcats.Count > 0)
                {
                    cmbxSubCats.DataSource = item_subcats;
                   
                }
                else
                {
                    cmbxSubCats.DataSource = item_subcats;
                    btnDeleteSubCat.Enabled = false;
                    btnUndeleteSubCat.Enabled = false;
                }
            }
        }

        private void cmbxSubCats_SelectedIndexChanged(object sender, EventArgs e)
        {

            subcat sub; 
            if (cmbxSubCats.Text != "")
            {
                sub = subCats.subcat_id(cmbxItems.Text, cmbxSubCats.Text);
                current_choice = sub;
                if (sub.is_active == 0)
                {
                    btnDeleteSubCat.Enabled = false;
                    btnUndeleteSubCat.Enabled = true;
                }
                else
                {
                    btnDeleteSubCat.Enabled = true;
                    btnUndeleteSubCat.Enabled = false;
                }
            }
        }

        private void btnUpdateSubCat_Click(object sender, EventArgs e)
        {
            subCats.update_subcat_name(current_choice, txtAddUpdateSubCat.Text);
            FillItemsComboBox();
        }

        private void btnAddSubCat_Click(object sender, EventArgs e)
        {
            subCats.Add_SubCat(subCats.get_item_by_name(cmbxItems.Text).id, txtAddUpdateSubCat.Text);
            FillItemsComboBox();
        }

        public void Update_item_state()
        {
            subCats.Delete_Undelete_SubCat(current_choice);
            FillItemsComboBox();
        }

        private void btnDeleteSubCat_Click(object sender, EventArgs e)
        {
            Update_item_state();
        }

        private void btnUndeleteSubCat_Click(object sender, EventArgs e)
        {
            Update_item_state();
        }
    }
}
