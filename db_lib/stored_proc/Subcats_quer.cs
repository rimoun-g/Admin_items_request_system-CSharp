using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Subcats_quer
    {    
        public string Quer_GetAllSubCats { get; } = @"SELECT id, item_id, name, is_active FROM subcats";

        public string Quer_InsertSubcat { get; } = @"INSERT INTO subcats (item_id, name, is_active)
                                                        VALUES (@item_id, @name, @is_active)";
        public string Quer_UpdateSubCat_Name { get; } = @"Update subcats set name = @name WHERE id = @id;";

        public string Quer_UpdateSubCatState { get; } = @"Update subcats set is_active = @is_active WHERE id = @id;";

    }


}
