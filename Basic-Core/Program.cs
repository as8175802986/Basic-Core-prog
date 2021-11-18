using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-CoinFlip, 2-LeapYear, 3-PowerOfTwo, 4-HarmonicNumber, 5-Factors, 6-QuotientRemainder, 7-SwapNumber, 8-EvenOdd, 9-VowelConsonent,10-LargestOne,11-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin cf = new FlipCoin();
                        cf.Play();
                        break;
                    case 2:
                        LeapYear lp = new LeapYear();
                        lp.Check();
                        break;
                    case 3:
                        PowerOfTwo pft = new PowerOfTwo();
                        pft.Calculation();
                        break;
                    case 4:
                        HarmonicNumbers hn = new HarmonicNumbers();
                        hn.Calculation();
                        break;
                    case 5:
                        Factors fc = new Factors();
                        fc.Calculation();
                        break;
                    case 6:
                        QuotientRemianders qr = new QuotientRemianders();
                        qr.Calculation();
                        break;
                    case 7:
                        SwapNumbers sn = new SwapNumbers();
                        sn.Calculation();
                        break;
                    case 8:
                        EvenOdd ev = new EvenOdd();
                        ev.Calculation();
                        break;
                    case 9:
                        VowelConsonent vc = new VowelConsonent();
                        vc.Check();
                        break;
                    case 10:
                        LargestOFThree lt = new LargestOFThree();
                        lt.Check();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}
