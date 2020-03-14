using db_lib.stored_proc;
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

        /// <summary>
        /// Adding a new transaction to the transactions table
        /// </summary>
        /// <param name="trans">the information included in transaction class</param>
        /// <returns>returns the transaction class</returns>
        public transaction AddTransaction(transaction trans)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                cnn.Execute(trans_Quer.Quer_InsertTransaction, new { trans.emp_no, trans.item_id, trans.subcat_id, trans.unit_price, trans.quantity, trans.user_id, trans.date, trans.delivery_date, trans.remarks });
                return trans;
            }
        }

        /// <summary>
        /// Delete a specific transaction based on its id
        /// </summary>
        /// <param name="id">the transaction id in the transactions table</param>
        public void Delete_Transaction(string id)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                cnn.Execute(trans_Quer.Quer_DeleteTransaction, new {id});
            }
        }


        
        /// <summary>
        /// Get all transactions for a specific employee based on the employee number
        /// </summary>
        /// <param name="emp">the employee number</param>
        /// <returns>returns list of employee transactions class</returns>
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

        /// <summary>
        /// Get the transactions of all employees
        /// </summary>
        /// <returns></returns>
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
