using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.code;
using DataLayer.Models;

namespace Admin_items.AppLayer
{
    public class Transactions
    {


        Employees employees = new Employees();
        transaction_code transaction_Code = new transaction_code();
        SubCats subCats = new SubCats();
        public string get_employee_by_code(int code)
        {
            var emp =   employees.Get_employee_by_Code(code);
            string info;
            if (emp is null)
            {
                return info = $"Employee info: EMPLOYEE IS NOT FOUND";
            }
            else
            {
                info = $"Employee info: {emp.name} - {emp.job} - {emp.dept} - {emp.section}";
                return info;
            }
        }


        public List<Employee_Transactions> get_emp_transactions(int code)
        {

            var emp = employees.Get_employee_by_Code(code);

            if (emp is null)
            {
                return null;
            }
            else
            {
                var emp_trans = transaction_Code.getemploeeTransactions(emp);
                return emp_trans;
            }


        }




        public List<subcat> get_active_subcats()
        {
            var sub_cats = subCats.GetALLSubCats();

            List<subcat> active_subs = new List<subcat>();

            foreach (var sub in sub_cats)
            {
                if (sub.is_active == 1)
                {
                    active_subs.Add(sub);
                }
            }
             return active_subs;
        }


        public List<item> get_active_items()
        {
            var all_items = subCats.GetALLItemsForSubCats();

            List<item> active_items = new List<item>();

            foreach (var item in all_items)
            {
                if (item.is_active == 1)
                {
                    active_items.Add(item);
                }
            }
            return active_items;
        }

        public List<string> GetItemSubCat(int item_id)
        {
            List<string> subcats_names = new List<string>();

            var subcats = get_active_subcats();

            List<string> sub_names = new List<string>();

            foreach (var itm in subcats)
            {
                if (itm.item_id == item_id)
                {
                    sub_names.Add(itm.name);
                }
            }

            return sub_names;
        }

        public List<string> Items_names()
        {
            List<string> items_names = new List<string>();

            var active_items = get_active_items();

            foreach (item itm in active_items)
            {
                items_names.Add(itm.name);
            }
            return items_names;
        }

        public item get_item_by_name(string item)
        {
            item my_item = new item();
            my_item = subCats.get_item_by_name(item);
            return my_item;
        }

        public subcat get_subcat_by_name(string itemname, string subcatename)
        {
            var sub = subCats.subcat_id(itemname, subcatename);

            return sub;
        }

        public void AddTransaction(string emp_no, int item_id, int subcat_id, decimal unit_price, decimal quantity, int user_id, string delivery_date, string remarks)
        {
            int employee_no;

            Int32.TryParse(emp_no, out employee_no);

            if (employee_no > 0 & !string.IsNullOrEmpty(emp_no.ToString()))
            {
                var emp = get_employee_by_code(employee_no);

                if (emp != "Employee info: EMPLOYEE IS NOT FOUND")
                {
                    transaction trans = new transaction();
                    trans.emp_no = employee_no;
                    trans.item_id = item_id;
                    trans.subcat_id = subcat_id;
                    trans.unit_price = unit_price;
                    trans.quantity = quantity;
                    trans.user_id = user_id;
                    trans.date = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
                    trans.delivery_date = delivery_date;
                    trans.remarks = remarks;
                    transaction_Code.AddTransaction(trans);
                    System.Windows.Forms.MessageBox.Show("The transactions has been added successfully!", "Done", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(emp,"check employee number",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
        
        
    }
}
