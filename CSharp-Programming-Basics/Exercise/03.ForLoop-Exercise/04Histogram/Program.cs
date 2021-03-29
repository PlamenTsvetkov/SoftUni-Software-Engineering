using System;

namespace _04Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int sumP1 = 0;
            int sumP2 = 0;
            int sumP3 = 0;
            int sumP4 = 0;
            int sumP5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    sumP1 += 1;
                }
                else if (200<=num & num<=399)
                {
                    sumP2 += 1;
                }
                else if (400 <= num & num <=599)
                {
                    sumP3 += 1;
                }
                else if (600 <= num & num <= 799)
                {
                    sumP4 += 1;
                }
                else
                {
                    sumP5 += 1;
                }

            }
            double percentSumP1 = (sumP1 / n * 100);
            double percentSumP2 = (sumP2 / n * 100);
            double percentSumP3 = (sumP3 / n * 100);
            double percentSumP4 = (sumP4 / n * 100);
            double percentSumP5 = (sumP5 / n * 100);
            Console.WriteLine($"{percentSumP1:F2}%");
            Console.WriteLine($"{percentSumP2:F2}%");
            Console.WriteLine($"{percentSumP3:F2}%");
            Console.WriteLine($"{percentSumP4:F2}%");
            Console.WriteLine($"{percentSumP5:F2}%");
        }
    }
}
