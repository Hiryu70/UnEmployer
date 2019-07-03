using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    internal static class Report
    {
         public static void ShowPensiyuInConsole(Employee employee)
        {
            Console.WriteLine($"Sotrudnik {employee.Name} skopil: {employee.Getpensiyu()}");
            Console.ReadKey();
        }
    }
}
