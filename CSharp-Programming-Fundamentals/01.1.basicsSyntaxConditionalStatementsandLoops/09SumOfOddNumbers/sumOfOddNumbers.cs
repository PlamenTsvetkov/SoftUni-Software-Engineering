using System;

namespace _09SumOfOddNumbers
{
    class sumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalNum = 0;
            for (int i = 1; i < 2*n; i+=2)
            {
                Console.WriteLine(i);
                totalNum += i;
            }
            Console.WriteLine($"Sum: {totalNum}");
        }
    }
}
