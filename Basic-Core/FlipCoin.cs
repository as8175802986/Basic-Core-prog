using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class FlipCoin
    {
        public void Play()
        {
            Console.WriteLine("Enter the Number of times want to flip the coin");
            int num = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int headCount = 0, tailCount = 0;
            double percentage;
            for (int i = 0; i < num; i++)
            {
                double flip = rand.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                    percentage = (headCount / num) * 100;
                    Console.WriteLine("Percentage of Heads vs Tails is: " + percentage);
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                    percentage = (tailCount / num) * 100;
                    Console.WriteLine("Percentage of Heads vs Tails is: " + percentage);
                }

            }
        }
    }
}
