using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;
using db_lib.db_conn;
using db_lib.stored_proc;
using Dapper;
using DataLayer.Interfaces;
using System.Linq;

namespace DataLayer.code
{
    public class subcat_code : db_connection, Isubcat
    {
        Subcats_quer subcat_Quer = new Subcats_quer();
        /// <summary>
        /// Get all items subcategories
        /// </summary>
        /// <returns>returns a list of all subcategories</returns>
        public List<subcat> GetAllSubcats()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<subcat>(subcat_Quer.Quer_GetAllSubCats);

                return result.ToList();
            }

        }

        /// <summary>
        /// Adds a new subcategory to an item
        /// </summary>
        /// <param name="subcat_name">the name of subcategory</param>
        /// <returns>returns the s</returns>
        public subcat AddSubCat(subcat subcat_name)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(subcat_Quer.Quer_InsertSubcat, new { subcat_name.item_id, subcat_name.name, subcat_name.is_active });

                return subcat_name;
            }
        }

        /// <summary>
        /// Update a subcategory of an item 
        /// </summary>
        /// <param name="sub">subcategory loaded in class</param>
        /// <param name="newName"> the new name of the subcategory</param>
        /// <returns></returns>
        public subcat UPdateSubcatName(subcat sub, string newName)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();

                sub.name = newName;
                var rows = cnn.Execute(subcat_Quer.Quer_UpdateSubCat_Name, new { sub.name, sub.id });

                return sub;
            }
        }


        /// <summary>
        /// Update the subcategory state in case of deletion
        /// </summary>
        /// <param name="sub">the subcategory</param>
        /// <returns></returns>
        public subcat UPdateItemState(subcat sub)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                if (sub.is_active == 0)
                {
                    sub.is_active = 1;
                }
                else
                {
                    sub.is_active = 0;
                }

                var rows = cnn.Execute(subcat_Quer.Quer_UpdateSubCatState, new { sub.is_active, sub.id });

                return sub;
            }
        }

    }
}
