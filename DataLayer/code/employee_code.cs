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
        /// <summary>
        /// get employee by its employee number
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public employee GetEmployee(int code)
        {

            using (var cnn = db_connect())
            {
                cnn.Open();
                employee result = cnn.Query<employee>(employees_Quer.Quer_GetEmployee, new { code }).FirstOrDefault();
                return result;
            }

        }

        
        /// <summary>
        /// add a new employee to employees table
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public employee AddEmployee(employee emp)
        {

            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(employees_Quer.Quer_AddEmployee, new { emp.code, emp.name, emp.job, emp.dept, emp.section } );

                return emp;
            }
        }

        /// <summary>
        /// get all employees 
        /// </summary>
        /// <returns></returns>
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
