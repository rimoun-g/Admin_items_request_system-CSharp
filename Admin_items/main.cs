using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.Forms.AdminToolsForms.subForms;
namespace Admin_items
{
    static class main
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new frmSubcat());
        }
    }
}
