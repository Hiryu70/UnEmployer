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

            Employee employer1 = new Employee();
            Employee employer2 = new Employee();
            Employee employer3 = new Employee();

            // List<Employee> employers = new List<Employee>() {employer1,employer2,employer3 };
            employer1.Age = 18;
            employer2.Age = 20;
            employer3.Age = 30;

            employer1.Name = "John";
            employer2.Name = "Andrey";
            employer3.Name = "Polina";

            employer1.Method(employer1.Age, employer1.Name);
            employer1.Method(employer2.Age, employer2.Name);
            employer1.Method(employer3.Age, employer3.Name);
            Console.ReadKey();
        }
    }
}
