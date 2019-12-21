using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    interface IEmployee
    {
        employee GetEmployee(int code);
        List<employee> GetAllemployees();
    }
}
