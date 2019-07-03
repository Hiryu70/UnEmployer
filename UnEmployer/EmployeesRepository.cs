
using System.Collections.Generic;

namespace UnEmployer
{
    internal class EmployeesRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee() { Name = "Nikola", Age = 18,gender=Gender.Male },
                new Employee() { Name = "Andrey", Age = 20,gender=Gender.Male },
                new Employee() { Name = "Polina", Age = 30,gender=Gender.Male}
            };
            return  employees;
        }
    }
}

