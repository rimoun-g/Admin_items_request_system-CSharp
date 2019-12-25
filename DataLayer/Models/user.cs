using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class user
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int level { get; set; }
    }
}
