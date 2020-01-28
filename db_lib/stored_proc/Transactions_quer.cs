using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Transactions_quer
    {
        public string Quer_InsertTransaction { get; } = @"INSERT INTO transactions (emp_no, item_id, subcat_id, unit_price, quantity, user_id, date, delivery_date, remarks) VALUES (@emp_no, @item_id, @subcat_id, @unit_price, @quantity, @user_id, @date, @delivery_date, @remarks)";
        public string Quer_GetEmployeeTrans { get; } = @"With main as (SELECT t.emp_no , c.name AS item, sc.name AS subcat,  t.unit_price, t.quantity, t.delivery_date, t.remarks FROM transactions t Left JOIN items c ON t.item_id = c.id Left JOIN employees e ON e.code = t.emp_no Left Join subcats sc ON sc.id = t.subcat_id) Select * from main WHERE emp_no = @emp_no";

        public string Quer_GetAllEmployeeTrans { get; } = @"With main as (SELECT t.id, t.emp_no,  t.unit_price, t.quantity, t.delivery_date, t.remarks FROM transactions t) Select * from main";
        public string Quer_DeleteTransaction { get; } = "DELETE FROM transactions WHERE id=@id";

    }
}
