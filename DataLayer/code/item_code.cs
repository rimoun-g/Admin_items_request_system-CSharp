using System;
using System.Collections.Generic;
using System.Text;
using db_lib.stored_proc;
using DataLayer.Interfaces;
using DataLayer.Models;
using db_lib.db_conn;
using Dapper;
using System.Linq;

namespace DataLayer.code
{
    public class item_code : db_connection, Iitem
    {
        items_quer Items_Quer = new items_quer();

        /// <summary>
        /// Add a new item
        /// </summary>
        /// <param name="itemname"></param>
        /// <returns></returns>
        public item AddItem(item itemname)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(Items_Quer.Quer_InsertItem, new  { itemname.name, itemname.is_active }  );

                return itemname;
            }
        }

        /// <summary>
        /// Get all items in items table
        /// </summary>
        /// <returns>returns a list of items</returns>
        public List<item> GetAllItems()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<item>(Items_Quer.Quer_GetAllItems);

                return result.ToList();
            }

        }

        /// <summary>
        /// get item state if its marked as deleted or not
        /// </summary>
        /// <param name="item_name"></param>
        /// <returns></returns>
        public item GetItem(string item_name)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                item result = cnn.Query<item>(Items_Quer.Quer_getItemState, new {item_name} ).FirstOrDefault();

                if (result is null)
                {
                    return null;
                }
                else
                {
                    return result;

                }

                
            }
        }

        /// <summary>
        /// update the state of an item
        /// </summary>
        /// <param name="itemname"></param>
        /// <returns></returns>
        public item UPdateItemState(item itemname)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                if (itemname.is_active == 0)
                {
                    itemname.is_active = 1;
                }
                else
                {
                    itemname.is_active = 0;
                }
                
                var rows = cnn.Execute(Items_Quer.Quer_UpdateItemState, new {itemname.is_active, itemname.id});

                return itemname;
            }
        }

        /// <summary>
        /// update the name of an item
        /// </summary>
        /// <param name="itemname"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public item UPdateItemName(item itemname, string newName)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();

                itemname.name = newName.ToLower();
                var rows = cnn.Execute(Items_Quer.Quer_UpdateItemName, new { itemname.name, itemname.id });

                return itemname;
            }
        }
    }


}
