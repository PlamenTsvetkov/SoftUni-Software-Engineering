using System;

namespace _09AnnaLeftAndRightSum
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
                int num1 = int.Parse(Console.ReadLine());
                sum1 += num1;
            }
            for (int i = 0; i < n; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum2 += num2;
            }
            int diff = Math.Abs(sum2 - sum1);
            if (sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
            

        }
    }
}
