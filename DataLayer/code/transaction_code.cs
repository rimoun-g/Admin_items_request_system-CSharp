﻿using db_lib.stored_proc;
using System;
using System.Collections.Generic;
using System.Text;
using db_lib.db_conn;
using DataLayer.Models;
using Dapper;
using System.Linq;

namespace DataLayer.code
{
    public class transaction_code : db_connection, Itransaction
    {
        Transactions_quer trans_Quer = new Transactions_quer();

        public transaction AddTransaction(transaction trans)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                cnn.Execute(trans_Quer.Quer_InsertTransaction, new { trans.emp_no, trans.item_id, trans.subcat_id, trans.unit_price, trans.quantity, trans.user_id, trans.date, trans.delivery_date, trans.remarks });
                return trans;
            }
        }

        public void Delete_Transaction(string id)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                cnn.Execute(trans_Quer.Quer_DeleteTransaction, new {id});
            }
        }


        

        public List<Employee_Transactions> getemploeeTransactions(employee emp)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                int emp_no = emp.code;
                var result = cnn.Query<Employee_Transactions>(trans_Quer.Quer_GetEmployeeTrans, new { emp_no });

                return result.ToList();
            }

        }

        public List<transaction> getAllemploeeTransactions()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<transaction>(trans_Quer.Quer_GetAllEmployeeTrans);

                return result.ToList();
            }

        }
    }
}
