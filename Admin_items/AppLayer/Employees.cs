using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.code;
using DataLayer.Models;

namespace Admin_items.AppLayer
{
    public class Employees
    {
        employee_code employee_Code = new employee_code();

        public employee Get_employee_by_Code(int code)
        {
            var emp =  employee_Code.GetEmployee(code);
            if (emp is null)
            {
                return null;
            }
            return emp;
        }

    }
}
