using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class SwapNumbers
    {
        public void Calculation()
        {
            int temp = 0;
            Console.WriteLine("Enter the 1st Number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            temp = numOne;
            numOne = numTwo;
            numTwo = temp;
            Console.WriteLine($" numOne :{numOne}");
            Console.WriteLine($" numTwo :{numTwo}");
        }
    }
}
