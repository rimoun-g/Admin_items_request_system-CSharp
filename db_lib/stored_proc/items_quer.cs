﻿using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class items_quer
    {
        public string Quer_GetAllItems { get; } = @"SELECT id, name, is_active 
                                                        FROM items";
        public string Quer_GetAllActiveItems { get; } = @"SELECT id, name, is_active 
                                                        FROM items WHERE is_active=1";

        public string Quer_InsertItem { get; } = @"INSERT INTO items (name, is_active)
                                                        VALUES (@name, @is_active)";

        public string Quer_getItemState { get; } = @"SELECT id, name, is_active 
                                                     FROM items WHERE name =";

    }
}
