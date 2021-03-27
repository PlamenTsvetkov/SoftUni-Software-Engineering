using System;

namespace _10NakovHalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете n брой числа : ");
            int n = int.Parse(Console.ReadLine());

            int maxSum = int.MinValue;
            int totalN = 0;


            for (int i = 1; i <= n; i++)
            {
                Console.Write("number {0} = ",i);
                int num = int.Parse(Console.ReadLine());

                totalN += num;
                if (num > maxSum)
                {
                    maxSum = num;
                }
                
            }

            if (maxSum == totalN - maxSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxSum);
            }
            else
            {
                int diff = maxSum - (totalN -maxSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        } 
	}    
}
