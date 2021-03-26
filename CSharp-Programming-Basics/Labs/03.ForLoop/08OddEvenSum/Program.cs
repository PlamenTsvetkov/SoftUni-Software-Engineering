using System;

namespace _08OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n брой цели числа: ");
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("num {0} = ",i);
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }        
            }
            int diff = Math.Abs(oddSum - evenSum);
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = "+oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+diff);
            }
        }
    }
}
