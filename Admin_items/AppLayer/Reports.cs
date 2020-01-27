using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.code;
using DataLayer.Models;
using System.IO;
using System.Windows.Forms;


namespace Admin_items.AppLayer
{
    public class Reports
    {
        report_code rep_code = new report_code();

        public List<Report> GetAllTransactions()
        {
            var trans = rep_code.GetAllTransactions();
            return trans;
        }

        public void export_report_csv(List<Report> trans, string fileName)
        {
           if (trans?.Count > 0)
            {
                using (var file = File.CreateText(fileName))
                {
                    file.WriteLine(string.Join(",", "Employee code", "Employee Name", "Position", "Department", "Section", "Item", "Subcategory", "Unit Price", "Quantity", "Delivery Date", "Remarks"));

                    foreach (var item in trans)
                    {
                        file.WriteLine(string.Join(",", item.emp_no, item.name, item.dept, item.section, item.item, item.subcat, item.unit_price, item.quantity, item.delivery_date, item.remarks));
                    }
                }
                MessageBox.Show("Your report:\n" + fileName + "\nWas Saved Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void CalculateStatistics(List<Report> transactions)
        {
            if (transactions?.Count >0)
            {
                string trans_count = transactions?.Count.ToString();
                string emp_count = transactions?.GroupBy(u => u.emp_no).Count().ToString();
                string unique_item_count = transactions?.GroupBy(u => u.item).Count().ToString();
                string item_count = transactions?.Sum(u => int.Parse(u.quantity)).ToString();
                string subcat_count = transactions?.GroupBy(u => u.subcat).Count().ToString();
                string dept_count = transactions?.GroupBy(u => u.dept).Count().ToString();
                string items_count = transactions?.GroupBy(u => u.dept).Count().ToString();
                string items_total = transactions?.Sum(u => int.Parse(u.quantity) * float.Parse(u.unit_price)).ToString();
                MessageBox.Show("Number of Transactions: " + trans_count +
                                "\nNumber of employees: " + emp_count +
                                "\nNumber of Departments: " + dept_count +
                                "\nNumber of unique items: " + unique_item_count +
                                "\nTotal Number of items: " + item_count +
                                "\nTotal value of items: " + items_total +
                                "\nNumber of unique subcategories: " + subcat_count


                    ,"Statistics of results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public List<string> creat_years_list()
        {
            var trans = GetAllTransactions();
            List<string> years = new List<string>();

            foreach (var item in trans)
            {
                years.Add(item.delivery_date.Substring(0, 4));
            }
            years.Add("All");
            return years.Distinct().ToList();

        }

        public List<string> creat_month_list()
        {
            var trans = GetAllTransactions();
            List<string> months = new List<string>();

            foreach (var item in trans)
            {
                months.Add(item.delivery_date.Substring(5, 2));
            }
            months.Add("All");
            return months.Distinct().ToList();

        }

        public List<Report> Filter_Transactions(string keyword, string year, string month)
        {
            if (year == "All" & month== "All")
            {
                return Filter_All_Transactions(keyword);
            }
            else if (year != "All" & month == "All")
            {
               return rep_code.GetFilteredTransactionsByYear(keyword, year);
            }
            else if (year == "All" & month != "All")
            {
                return rep_code.GetFilteredTransactions_By_Mon_only(keyword, month);
            }
            else
            {
                return rep_code.GetFilteredTransactions_Y_Mon(keyword, year, month);

            }

        }

        public List<Report> Filter_All_Transactions(string keyword)
        {
            var trans = rep_code.GetAllFilteredTransactions(keyword);
            return trans;
        }
        

  
    }
}
