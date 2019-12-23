using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_items.Forms.AdminToolsForms.subForms;
using Admin_items.Forms.DataEntry;
namespace Admin_items
{
    static class main
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new frmDataEntry());
        }
    }
}
