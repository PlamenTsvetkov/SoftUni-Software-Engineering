using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numMax = int.MinValue;
            int sum = 0;


            for (int i = 0; i < n; i++)
            {
               int num = int.Parse(Console.ReadLine());
                sum += num;
                if (numMax < num)
                {
                    numMax = num;
                }

            }
            int diff = sum - numMax;
            int diff2 = numMax - (sum - numMax);
            if (numMax == diff)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {diff}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(diff2)}");
            }
        }
    }
}
