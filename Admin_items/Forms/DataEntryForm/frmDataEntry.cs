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

namespace Admin_items.Forms.DataEntry
{

    public partial class frmDataEntry : Form
    {
        AppLayer.DataEntry data = new AppLayer.DataEntry();
        public frmDataEntry()
        {
            InitializeComponent();
            FillItemsComboBox();
        }


        
        public string get_employee_info(int code)
        {
           string info = data.get_employee_by_code(code);

            return info;
        }

        private void txtEmpNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               lblEmployeeInfo.Text = get_employee_info(Convert.ToInt32(txtEmpNumber.Text));
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

        }
    }
}
