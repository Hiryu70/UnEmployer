using System;

namespace UnEmployer
{
    internal static class Report
    {
         public static void ShowPensiyuInConsole(Employee employee)
        {
            Console.WriteLine($"Sotrudnik {employee.Name} skopil: {employee.Getpensiyu()}");

        }
    }
}
