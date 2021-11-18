using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class QuotientRemianders
    {
        public void Calculation()
        {
            int qutoient, remainder;
            Console.WriteLine("Enter The Divindend ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Divisor ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            qutoient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Here is the Quotient is:" + qutoient);
            Console.WriteLine("Here is the Remainder is: " + remainder);
        }
    }
}
