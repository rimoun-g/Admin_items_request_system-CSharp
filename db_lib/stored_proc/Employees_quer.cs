using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class Employees_quer
    {
        public string Quer_GetAllEmployees { get; } = @"SELECT id, code, name, job, dept, section FROM employees";
        public string Quer_GetEmployee { get; } = @"SELECT id, code, name, job, dept, section FROM employees WHERE code = @code";
    }
}
