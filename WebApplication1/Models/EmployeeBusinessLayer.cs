using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
           
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Ram",
                Gender = "Male",
                City = "Mumbai",
                Salary = 60000,
                Address = "Andheri"
            };

            return employee;
        }
    }

}