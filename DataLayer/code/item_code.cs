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

        public item AddItem(item itemname)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(Items_Quer.Quer_InsertItem, new  { itemname.name, itemname.is_active }  );

                return itemname;
            }
        }


        public List<item> GetAllItems()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<item>(Items_Quer.Quer_GetAllItems);

                return result.ToList();
            }

        }

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
