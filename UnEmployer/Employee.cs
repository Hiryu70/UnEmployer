﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnEmployer
{
    class Employee:Human
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Age { get; set; }

        public int Method(int age)
        {
            age = Age;
            int money = 0;
                for(int i = age; i < 68; i++)
            {
                money += 100000;
               
            }
            return money;
        }
    }
}