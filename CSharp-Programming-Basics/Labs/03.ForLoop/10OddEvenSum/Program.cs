using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int num1 = int.Parse(Console.ReadLine());
                    sum1 += num1;
                }
                else
                {
                    int num2 = int.Parse(Console.ReadLine());
                    sum2 += num2;
                }
            }
            int diff = Math.Abs(sum1 - sum2);
            if (sum1==sum2)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
