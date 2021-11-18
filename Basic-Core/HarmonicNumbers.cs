using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class HarmonicNumbers
    {
		int power(int bas, int exponent)
		{
			int power = 1;
			for (int i = 1; i <= exponent; i++)
				power = power * bas;
			return power;
		}
		public void Calculation()
		{
			int bas = 2;
			Console.WriteLine("Enter the Power No.");
			int exponent = Convert.ToInt32(Console.ReadLine());
			int pow = power(bas, exponent);
			Console.WriteLine(bas + "to the power of" + exponent + "is : " + pow);
		}
	}
}
