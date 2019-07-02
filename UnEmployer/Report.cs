using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Report
    {
         public  Report(string name,int money)
        {
            Console.WriteLine($"Sotrudnik {name} skopil: {money}");
            Console.ReadKey();
        }


    }
}
