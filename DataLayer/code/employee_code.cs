using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using DataLayer.Models;
using db_lib.db_conn;
using db_lib.stored_proc;
using DataLayer.Interfaces;
namespace DataLayer.code
{
    public class employee_code: db_connection, IEmployee
    {

       

        Employees_quer employees_Quer = new Employees_quer();
        public employee GetEmployee(int code)
        {

            using (var cnn = db_connect())
            {
                cnn.Open();
                employee result = cnn.Query<employee>(employees_Quer.Quer_GetEmployee, new { code }).FirstOrDefault();
                return result;
            }

        }

        

        public employee AddEmployee(employee emp)
        {

            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(employees_Quer.Quer_GetEmployee, emp);

                return emp;
            }


        }

        public List<employee> GetAllemployees()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<employee>(employees_Quer.Quer_GetAllEmployees);

                return result.ToList();
            }
        }
    }
}
