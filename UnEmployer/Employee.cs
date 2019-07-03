using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Employee : Human
    {
        internal enum Koefficient { KoeffForMale = 1, KoeffForFemale = 2 }
        int pensiya = 0;
        private readonly int Sum = 100000;

        public int GetPension()
        {
            for (int i = Age; i < 68; i++)
            {
                switch (Gender)
                {
                    case "Male":
                        pensiya = Sum * (int)Koefficient.KoeffForMale;
                        break;
                    case "Female":
                        pensiya += Sum * (int)Koefficient.KoeffForFemale;
                        break;
                }
            }
            return pensiya;
        }
    }
}

