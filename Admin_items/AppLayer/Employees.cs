using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            return list_jobs.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(q => q).ToList();
        }

        public List<string> GetAllDepts()
        {
            List<string> list_depts = new List<string>();
            var emps = GetALLEmployees();
            foreach (var emp in emps)
            {
                list_depts.Add(emp.dept);
            }
            return list_depts.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(q => q).ToList();
        }


        public List<string> GetAllSections()
        {
            List<string> list_sections = new List<string>();
            var emps = GetALLEmployees();
            foreach (var emp in emps)
            {
                list_sections.Add(emp.section);
            }
            return list_sections.Distinct().OrderBy(q => q).ToList();
        }

        public void AddEmployee(int code, string name, string job, string dept, string section)
        {

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            employee new_emp = new employee();

            var chk_dup = Get_employee_by_Code(code);

            if (chk_dup is null)
            {
                if (!string.IsNullOrEmpty(name?.Trim()))
                {
                    new_emp.code = code;
                    new_emp.name = textInfo.ToTitleCase(name.Trim());
                    new_emp.job = job;
                    new_emp.dept = dept;
                    new_emp.section = section;

                    employee_Code.AddEmployee(new_emp);

                    MessageBox.Show("The Employee was added successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Name field is empty", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         

            }
            else
            {
                MessageBox.Show("The Employee you are trying to add already exists!", "Employee Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
