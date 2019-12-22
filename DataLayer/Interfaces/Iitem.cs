using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface Iitem
    {
        item AddItem(item itemname);
        List<item> GetAllItems();

        item GetItem(string item_name);
    }
}
