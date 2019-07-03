using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var repository = new EmployeesRepository();
            var employees = repository.GetEmployees();
            foreach (var employee in employees)
            {
                Report.ShowPensiyuInConsole(employee);
            }
            Console.ReadKey();

        }
    }
}
