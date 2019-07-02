using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class EmployeesRepository:Human
    {
        public List<Employee> GetEmployees()
        {

            List<Employee> GetCollection = new List<Employee>(3)
            {
                new Employee() { Name = "Nikola", Age = 18 },
                new Employee() { Name = "Andrey", Age = 20 },
                new Employee() { Name = "Polina", Age = 30 }
            };

            return  GetCollection;

        }
    }
}

