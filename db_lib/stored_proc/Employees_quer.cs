using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Employees_quer
    {
        // get all employees from the employees table
        public string Quer_GetAllEmployees { get; } = @"SELECT id, code, name, job, dept, section FROM employees";
        // get a specific employee from the employees table 
        public string Quer_GetEmployee { get; } = @"SELECT id, code, name, job, dept, section FROM employees WHERE code = @code";
        // insert a new employee
        public string Quer_AddEmployee { get; } = @"INSERT INTO employees (code, name, job, dept, section) Values (@code, @name, @job, @dept, @section)";
    }
}
