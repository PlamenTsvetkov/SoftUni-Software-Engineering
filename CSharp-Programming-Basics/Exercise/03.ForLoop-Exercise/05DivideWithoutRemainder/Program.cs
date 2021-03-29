using System;

namespace _05DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double sumP1 = 0;
            double sumP2 = 0;
            double sumP3 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 ==0)
                {
                    sumP1 += 1;
                }
                if (num % 3 == 0)
                {
                    sumP2 += 1;
                }
                if (num % 4 == 0)
                {
                    sumP3 += 1;
                }
            }
            double percentSumP1 = sumP1 / n * 100;
            double percentSumP2 = sumP2 / n * 100;
            double percentSumP3 = sumP3 / n * 100;
            Console.WriteLine($"{percentSumP1:F2}%");
            Console.WriteLine($"{percentSumP2:F2}%");
            Console.WriteLine($"{percentSumP3:F2}%");
        }
    }
}
