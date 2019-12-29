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

            var items = Items_Names();
            bool chk_dup = items.Contains(item_name.ToLower());

            if (!string.IsNullOrEmpty(item_name.Trim()) & !chk_dup)
            {
                item _item = new item();
                _item.name = item_name.Trim().ToLower();
                _item.is_active = 1;
                item_Code.AddItem(_item);

                MessageBox.Show("The Item was added successfully!","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Item you are trying to add is empty or already in the database.", "Empty or Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<item> GetllALLITEMS()
        {
            var list = item_Code.GetAllItems();
            return list;
        }

        public List<string> Items_Names()
        {
            var all_items_names = new List<string>();

            var items = GetllALLITEMS();

            if (items.Count() > 0)
            {

                foreach (var item in items)
                {
                    all_items_names.Add(item.name);
                }

                
                return all_items_names;
            }
            else
            {
                return null;
            }
        }
    

           


        public item item_by_name(string item_name)
        {
            var items = GetllALLITEMS();

            if (items.Count > 0)
            {
                foreach (item _value in items)
                {
                    if (_value.name == item_name.ToLower())
                    {
                        return _value;
                    }
                } 
            }
            else
            {
                return null;
            }
            return null;

        } 


        public void UpdateItem(item item)
        {
            item_Code.UPdateItemState(item);
            MessageBox.Show("The item has been deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UndoUpdateItem(item item)
        {
            item_Code.UPdateItemState(item);
            MessageBox.Show("The item has been restored.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateItemName(item item, string newName)
        {
            var names = Items_Names();
            bool chk_item = names.Contains(item.name);

            bool chk_dup = names.Contains(newName.ToLower());

            if ((chk_dup == false) & (chk_item == true) & (!string.IsNullOrEmpty(newName.Trim())))
            {
                item_Code.UPdateItemName(item, newName.Trim().ToLower());
                MessageBox.Show("The item has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Item you are trying to update is empty or already in the database.", "Empty or Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
