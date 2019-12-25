using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class transaction
    {
        public int id { get; set; }
        public int emp_no { get; set; }
        public int item_id { get; set; }
        public int subcat_id { get; set; }
        public decimal value { get; set; }
        public decimal quantity { get; set; }
        public int user_id { get; set; }
        public string date { get; set; }
    }
}
