using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using DataLayer.code;
using System.Windows.Forms;

namespace Admin_items.AppLayer
{
    public class Items
    {
        item_code item_Code = new item_code();

        public List<string> items_names = new List<string>();

        public void add_item(string item_name)
        {

            bool chk_dup = items_names.Contains(item_name);

            if (!string.IsNullOrEmpty(item_name.Trim()) & chk_dup==false)
            {
                

                item _item = new item();
                _item.name = item_name;
                _item.is_active = 1;

                item_Code.AddItem(_item);

                MessageBox.Show("The Item was added successfully!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Item you are trying to add is empty or already in the database.", "Empty or Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> GetllALLITEMS()
        {
            var list = item_Code.GetAllItems();

            var all_items_names = new List<string>();

           if (list.Count() > 0)
            {
                
                foreach (var item in list)
                {
                    all_items_names.Add(item.name);
                }

                items_names = all_items_names;
                return all_items_names;
            }
            else
            {
                return null;
            }
        }




    }
}
