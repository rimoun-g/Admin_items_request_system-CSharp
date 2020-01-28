using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Reports_quer
    {
        public string Quer_GetAllTrans { get; } = @"With main as (SELECT t.emp_no , e.name, e.job, e.dept, e.section, c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks , u.user_name FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id Left JOIN users u ON u.id = t.user_id) Select * from main";
        public string Quer_FilterTransByYearMonth { get; } = @"With main as (SELECT t.emp_no , e.name, e.job, e.dept, e.section, c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks , u.user_name FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id Left JOIN users u ON u.id = t.user_id) Select *, substr(delivery_date,1,4) AS year, substr(delivery_date,6,2) AS month from main WHERE ((emp_no LIKE @keyword ) OR (dept LIKE @keyword ) OR  (section LIKE @keyword) OR (item LIKE @keyword)) AND year = @year AND month = @month";
        public string Quer_FilterTransByMonth { get; } = @"With main as (SELECT t.emp_no , e.name, e.job, e.dept, e.section, c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks , u.user_name FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id Left JOIN users u ON u.id = t.user_id) Select *, substr(delivery_date,6,2) AS month from main WHERE ((emp_no LIKE @keyword ) OR (dept LIKE @keyword ) OR  (section LIKE @keyword) OR (item LIKE @keyword)) AND month = @month";
        public string Quer_FilterTrans_By_Year_Only { get; } = @"With main as (SELECT t.emp_no , e.name, e.job, e.dept, e.section, c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks , u.user_name FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id Left JOIN users u ON u.id = t.user_id) Select *, substr(delivery_date,1,4) AS year from main WHERE ((emp_no LIKE @keyword ) OR (dept LIKE @keyword ) OR  (section LIKE @keyword) OR (item LIKE @keyword)) AND year = @year";
        public string Quer_AllFilterTrans { get; } = @"With main as (SELECT t.emp_no , e.name, e.job, e.dept, e.section, c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks , u.user_name FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id Left JOIN users u ON u.id = t.user_id) Select *, substr(delivery_date,1,4) AS year from main WHERE ((emp_no LIKE @keyword ) OR (dept LIKE @keyword ) OR  (section LIKE @keyword) OR (item LIKE @keyword))";
    }
}
