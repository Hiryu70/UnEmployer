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

            int money1=employer1.Method(employer1.Age);
            int money2=employer2.Method(employer2.Age);
            int money3=employer3.Method(employer3.Age);
            employer2.Method(employer2.Age);
            employer3.Method(employer3.Age);
            Console.WriteLine("Sotrudnik " + employer1.Name + " skopil: " + money1);
            Console.WriteLine("Sotrudnik " + employer2.Name + " skopil: " + money2);
            Console.WriteLine("Sotrudnik " + employer3.Name + " skopil: " + money3);
            Console.ReadKey();
        }
    }
}
