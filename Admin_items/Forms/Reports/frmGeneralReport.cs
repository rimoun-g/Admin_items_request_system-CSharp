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

namespace Admin_items.Forms.Reports
{
    
    public partial class frmGeneralReport : Form
    {
        public frmGeneralReport()
        {
            InitializeComponent();
        }

        AppLayer.Reports reports = new AppLayer.Reports();
        private void frmGeneralReport_Load(object sender, EventArgs e)
        {
            dgGeneralReport.DataSource = reports.GetAllTransactions();
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            saveFdgExportToCSV.Filter = "(*.csv)|*.csv";
            saveFdgExportToCSV.FileName = "Report " + DateTime.Now.ToString().Replace("/","-").Replace(":", ".") + ".csv";

            if (saveFdgExportToCSV.ShowDialog() == DialogResult.OK)
            {
                reports.export_report_csv(reports.GetAllTransactions(), saveFdgExportToCSV.FileName);
               
            }

            // 
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            reports.CalculateStatistics(reports.GetAllTransactions());
        }



    }
}
