using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Employee : Human
    {


        public void GetSum(int age, string name)
        {
            int money = 0;
            for (int i = age; i < 68; i++)
            {
                money += 100000;

            }
            Report members = new Report(name,money);
            
            

        }
    }
}
