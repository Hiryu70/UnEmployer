using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Employee : Human
    {
        public int Getpensiyu()
        {
            int pensiya = 0;
            for (int i = Age; i < 68; i++)
            {
                pensiya += 100000;
            }
            return pensiya;
        }
    }
}
