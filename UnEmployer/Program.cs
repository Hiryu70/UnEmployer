using System;

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
