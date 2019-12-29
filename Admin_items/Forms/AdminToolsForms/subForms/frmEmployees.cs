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
            fill_comboboxes();
        }

        public void fill_comboboxes()
        {
            cmbxDepartment.DataSource = employees.GetAllDepts();
            cmbxEmpJob.DataSource = employees.GetAllJobs();
            cmbxSection.DataSource = employees.GetAllSections();
        }
    }
}
