using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace Admin_items.AppLayer
{
    public class DataEntry
    {


        Employees employees = new Employees();

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


    }
}
