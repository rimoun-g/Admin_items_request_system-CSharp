using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Transactions_quer
    {
        public string Quer_InsertTransaction { get; } = @"INSERT INTO transactions (emp_no, item_id, subcat_id, value, quantity, user_id, date) VALUES (@emp_no, @item_id, @subcat_id, @value, @quantity, @user_id, @date)";
        public string Quer_GetEmployeeTrans { get; } = @"With main as (SELECT t.id, t.emp_no , c.name AS item, sc.name AS subcat,  t.value, t.quantity, t.date FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id) Select * from main WHERE emp_no = @emp_no";
    }
}
