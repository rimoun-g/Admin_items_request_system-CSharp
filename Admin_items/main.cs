using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.Forms.AdminToolsForms.subForms;
using Admin_items.Forms.DataEntry;
using Admin_items.Forms;
using Admin_items.Forms.Login;
using Admin_items.Forms.Reports;
using System.Threading;

namespace Admin_items
{
    static class main
    {
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "MyApplicationName", out createdNew))
            {
                if (createdNew)
                {
                    Application.Run(new frmLogin());
                }
                else
                {
                    MessageBox.Show("The Application is already opened","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
