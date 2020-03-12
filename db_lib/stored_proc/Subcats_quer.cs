using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Subcats_quer
    {    
        // get all subcategories in subcategories the table
        public string Quer_GetAllSubCats { get; } = @"SELECT id, item_id, name, is_active FROM subcats";

        // insert a new subcategory
        public string Quer_InsertSubcat { get; } = @"INSERT INTO subcats (item_id, name, is_active)
                                                       VALUES (@item_id, @name, @is_active)";
        // update specific subcategory name based on its id
        public string Quer_UpdateSubCat_Name { get; } = @"Update subcats set name = @name WHERE id = @id;";

        // change the state is like marking the subcategory as deleted but in reality it is not deleted to keep the consistency of old records
        public string Quer_UpdateSubCatState { get; } = @"Update subcats set is_active = @is_active WHERE id = @id;";

    }


}
