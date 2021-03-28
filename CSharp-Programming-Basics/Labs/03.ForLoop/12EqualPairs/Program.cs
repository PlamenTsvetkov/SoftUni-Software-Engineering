using System;

namespace _12EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double firstSum = 0.00;
            double lastSum = 0.00;
            double diff = 0.00;


            for (int i = 0; i < n ; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                firstSum = num1 + num2;
                
                if (i > 0)
                {
                    lastSum = firstSum;
                    diff = Math.Max(lastSum, firstSum)- Math.Min(lastSum, firstSum);                    
                }
            }
            if (diff==0)
            {
                Console.WriteLine($"Yes, value={firstSum}");
            }
            else
            {
                Console.WriteLine($"No maddiff={diff}");
            }
        }
    }
}
