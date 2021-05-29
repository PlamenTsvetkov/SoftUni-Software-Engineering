using System;

namespace _09SumOfOddNumbersWhile
{
    class sumOfOddNumbersWhile
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalN = 0;
            int totalNum = 0;
            int num = 1;
            while (totalN!=n)
            {
                totalNum += num;
                Console.WriteLine(num);
                num += 2;
                totalN += 1;
            }
            Console.WriteLine($"Sum: {totalNum}");
        }
    }
}
