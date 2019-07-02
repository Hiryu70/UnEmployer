using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Program
    {
        static void Main(string[] args)
        {



            EmployeesRepository people = new EmployeesRepository();
            List<Employee> getemployees = people.GetEmployees();
            foreach (Employee members in getemployees)
            {
                members.GetSum(members.Age,members.Name);
            }








        }
    }
}
