using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    internal class EmployeesRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee() { Name = "Nikola", Age = 18, Gender="Male" },
                new Employee() { Name = "Andrey", Age = 20, Gender="Male" },
                new Employee() { Name = "Polina", Age = 30, Gender="Female" }
            };
            return  employees;
        }
    }
}

