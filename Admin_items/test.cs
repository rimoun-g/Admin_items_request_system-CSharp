using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.code;

namespace Admin_items
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee_code employee_ = new employee_code();

            //var result =  employee_.GetEmployee(2084);

            // MessageBox.Show("Name: " + result.name);
            var result = employee_.GetAllemployees();
            for (int i = 0; i < result.Count(); i++)
            {
                MessageBox.Show("Name: " + result[i].name);
            }
        }
    }
}
