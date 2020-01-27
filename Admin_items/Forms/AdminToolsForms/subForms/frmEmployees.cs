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
    public partial class frmEmployees : Form
    {
        Employees employees = new Employees();
        public frmEmployees()
        {
            InitializeComponent();
            Fill_comboboxes();
        }

        public void Fill_comboboxes()
        {
            cmbxDepartment.DataSource = employees.GetAllDepts();
            cmbxEmpJob.DataSource = employees.GetAllJobs();
            cmbxSection.DataSource = employees.GetAllSections();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employees.AddEmployee(int.Parse(txtEmpNum.Value.ToString()), txtEmpName.Text, cmbxEmpJob.Text, cmbxDepartment.Text, cmbxSection.Text);
        }

        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44)
            {
                e.Handled = true;
            }
        }
    }
}
