﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class LeapYear
    {
        public void Check()
        {
            Console.WriteLine("Enter the Year you want to check and that should be in four digit");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("The Given Year is Leap Year Which is: " + year);
            }
            else
            {
                Console.WriteLine("The Given Year is Not a Leap Year Which is: " + year);
            }
        }
    }
}
