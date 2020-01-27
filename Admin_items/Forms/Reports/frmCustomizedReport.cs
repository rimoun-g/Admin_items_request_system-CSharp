using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Admin_items.Forms.Reports
{
    public partial class frmCustomizedReport : Form
    {
        AppLayer.Reports reports = new AppLayer.Reports();
        public frmCustomizedReport()
        {
            InitializeComponent();
        }

        private void frmCustomizedReport_Load(object sender, EventArgs e)
        {
            var trans = reports.GetAllTransactions();
            dgReportResults.DataSource = trans;
            rename_datagrid_header();


            var years = reports.creat_years_list();
            cmbxYear.DataSource = years;
            cmbxYear.SelectedIndex = years.Count - 1;

            var months = reports.creat_month_list();
            cmbxMonth.DataSource = months;
            cmbxMonth.SelectedIndex = months.Count - 1;

            toolTipCustomizedReports.SetToolTip(txtSearchData, "The search is made in (Employee code, Department, section, item)");
        }

        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
                var trans = reports.Filter_Transactions(txtSearchData.Text,cmbxYear.Text,cmbxMonth.Text);
                dgReportResults.DataSource = trans; 
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            saveFdgExportToCSV.Filter = "(*.csv)|*.csv";
            saveFdgExportToCSV.FileName = "Report " + DateTime.Now.ToString().Replace("/", "-").Replace(":", ".") + ".csv";

            if (saveFdgExportToCSV.ShowDialog() == DialogResult.OK)
            {
                    var trans = reports.Filter_Transactions(txtSearchData.Text, cmbxYear.Text, cmbxMonth.Text);
                    reports.export_report_csv(trans, saveFdgExportToCSV.FileName);

            }

        }
        

        void rename_datagrid_header()
        {
            string[] Header_List = new string[11] { "Employee code", "Employee Name", "Position", "Department", "Section", "Item", "Subcategory", "Unit Price", "Quantity", "Delivery Date", "Remarks" };
            if (dgReportResults.Columns.Count == 11)
            {
                for (int i = 0; i < dgReportResults.Columns.Count; i++)
                {
                    dgReportResults.Columns[i].HeaderText = Header_List[i];
                }
            }
        }

        private void cmbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchData_TextChanged(sender,e);
        }

        private void btnCalculateStatistics_Click(object sender, EventArgs e)
        {
            var trans = reports.Filter_Transactions(txtSearchData.Text, cmbxYear.Text, cmbxMonth.Text);
            if (trans?.Count > 0)
            {
                reports.CalculateStatistics(trans);
            }
        }

        private void cmbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchData_TextChanged(sender, e);
        }
    }
}
