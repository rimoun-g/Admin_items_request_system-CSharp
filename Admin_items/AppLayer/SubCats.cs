using DataLayer.Models;
using DataLayer.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_items.AppLayer
{
    public class SubCats
    {
        public subcat_code subcat_Code = new subcat_code();


        public Items app_items = new Items();

        public List<subcat> GetALLSubCats()
        {
            var subcats = subcat_Code.GetAllSubcats();
            return subcats;
        }

        

        public List<item> GetALLItemsForSubCats()
        {
            var Items = app_items.GetllALLITEMS();
            return Items;
        }


        public List<string> GetItemSubCat(int item_id)
        {
            List<string> subcats_names = new List<string>();

            var subcats = GetALLSubCats();

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
            var items_names = app_items.Items_Names();
            return items_names;
        }

        public item get_item_by_name(string item_name)
        {
            var item = app_items.item_by_name(item_name);
            return item;
        }

        public subcat subcat_id (string item_name, string subcat_name)
        {
            var all_subs = GetALLSubCats();
            var curr_item = get_item_by_name(item_name);
            subcat sub;
            foreach (var s in all_subs)
            {
                if (s.item_id == curr_item.id & s.name == subcat_name)
                {
                    sub = s;
                    return sub;
                }
            }
            return null;
        }

        public void update_subcat_name(subcat curr_subcat, string new_name)
        {
            var curr_subs = GetItemSubCat(curr_subcat.item_id);

            bool chk_dup = curr_subs.Contains(new_name.ToLower());


            if (!chk_dup & !string.IsNullOrEmpty(new_name.Trim()))
            {
                subcat_Code.UPdateSubcatName(curr_subcat, new_name.Trim().ToLower());
                MessageBox.Show("The subcategory has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The subcategory you are trying to update is empty or already in the database.", "Empty or Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void Add_SubCat(int item_id, string sub_name)
        {
            var curr_subs = GetItemSubCat(item_id);
            bool chk_dup = curr_subs.Contains(sub_name.ToLower());

            if (!chk_dup & !string.IsNullOrEmpty(sub_name.Trim()))
            {

                subcat sub = new subcat();
                sub.item_id = item_id;
                sub.name = sub_name.ToLower();
                sub.is_active = 1;


                subcat_Code.AddSubCat(sub);
                MessageBox.Show("The subcategory has been added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The subcategory you are trying to add is empty or already in the database.", "Empty or Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Delete_Undelete_SubCat(subcat sub)
        {
           var my_sub = subcat_Code.UPdateItemState(sub);
            if (my_sub.is_active == 0)
            {
                MessageBox.Show("The subcategory has been deleted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The subcategory has been resotred.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
