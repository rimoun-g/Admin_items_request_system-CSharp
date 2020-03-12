using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class items_quer
    {
        // get all items in items table
        public string Quer_GetAllItems { get; } = @"SELECT id, name, is_active 
                                                        FROM items";
        // get all active items, which are not marked as deleted
        public string Quer_GetAllActiveItems { get; } = @"SELECT id, name, is_active 
                                                        FROM items WHERE is_active=1";

        // insert a new item
        public string Quer_InsertItem { get; } = @"INSERT INTO items (name, is_active)
                                                        VALUES (@name, @is_active)";
        // get item state as active or not
        public string Quer_getItemState { get; } = @"SELECT id, name, is_active
                                                    FROM items 
                                                    WHERE name = @name;";

        // update the active state of an existing item 
        public string Quer_UpdateItemState { get; } = @"Update items set is_active = @is_active WHERE id = @id;";

        // update the name of an existing item 
        public string Quer_UpdateItemName { get; } = @"Update items set name = @name WHERE id = @id;";
    }
}
