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

        public List<employee> GetALLEmployees()
        {
            return employee_Code.GetAllemployees();
        }

        public List<string> GetAllJobs()
        {
            List<string> list_jobs = new List<string>();
            var emps = GetALLEmployees();
            foreach (var emp in emps)
            {
                list_jobs.Add(emp.job);
            }
            return list_jobs.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
        }

        public List<string> GetAllDepts()
        {
            List<string> list_depts = new List<string>();
            var emps = GetALLEmployees();
            foreach (var emp in emps)
            {
                list_depts.Add(emp.dept);
            }
            return list_depts.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
        }


        public List<string> GetAllSections()
        {
            List<string> list_sections = new List<string>();
            var emps = GetALLEmployees();
            foreach (var emp in emps)
            {
                list_sections.Add(emp.section);
            }
            return list_sections.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
        }
    }
}
