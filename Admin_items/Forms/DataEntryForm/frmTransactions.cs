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

namespace Admin_items.Forms.DataEntry
{

    public partial class frmTransactions : Form
    {
        int user_id = 125;


        Transactions data = new Transactions();
        subcat current_choice;
        public frmTransactions()
        {
            InitializeComponent();
            FillItemsComboBox();
            dtpkrDeliveryDate.Value = DateTime.Today;
        }



        public string get_employee_info(int code)
        {
            string info = data.get_employee_by_code(code);

            return info;
        }

        private void txtEmpNumber_KeyDown(object sender, KeyEventArgs e)
        {

            Dictionary<int, string> header_dic = new Dictionary<int, string>();

            String[] Header_List = new string[8] { "ID", "Employee Code", "Item", "Subcategory", "Unit Price", "Quantity", "Delivery Date", "Remarks"};


            if (e.KeyCode == Keys.Enter)
            {
 
                var emp_code_parser = Int32.TryParse(txtEmpNumber.Text, out int emp_no);
                if (emp_code_parser)
                {
                    lblEmployeeInfo.Text = get_employee_info(emp_no);
                    dgEmployeeRecord.DataSource = data.get_emp_transactions(emp_no);
                    
                    if (dgEmployeeRecord.Columns.Count == 8)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            dgEmployeeRecord.Columns[i].HeaderText = Header_List[i];
                        }
                    }


                }
                
            }
        }

        public void FillItemsComboBox()
        {
            var items = data.Items_names();
            if (items.Count > 0)
            {
                cmbxItems.DataSource = items;
            }
        }

        private void cmbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxItems.Text != "")
            {

                var curr_item = data.get_item_by_name(cmbxItems.Text);

                var item_subcats = data.GetItemSubCat(curr_item.id);
                if (item_subcats.Count > 0)
                {
                    cmbxSubCats.DataSource = item_subcats;

                }
                else
                {

                    cmbxSubCats.DataSource = item_subcats;
                    cmbxSubCats.SelectedIndex = -1;
                    cmbxSubCats.ResetText();
                    var itm = data.get_item_by_name(cmbxItems.Text);
                    current_choice.item_id = itm.id;
                    current_choice.id = 0;
                }
            }
        }

        private void cmbxSubCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            subcat sub;
            if (cmbxSubCats.Text != "")
            {
                sub = data.get_subcat_by_name(cmbxItems.Text, cmbxSubCats.Text);
                current_choice = sub;
            }
            else
            {
                var itm = data.get_item_by_name(cmbxItems.Text);
                current_choice.item_id = itm.id;
                current_choice.id = 0;
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (current_choice is null)
            {
                MessageBox.Show("There are some missing information make sure you selected the items and subcategories as well as employee number","User Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                data.AddTransaction(txtEmpNumber.Text, current_choice.item_id, current_choice.id, txtValue.Value, txtQuantity.Value, user_id, dtpkrDeliveryDate.Value.ToString("yyyy/MM/dd"), txtRemarks.Text);
            }
      
                

        }
    }
}
