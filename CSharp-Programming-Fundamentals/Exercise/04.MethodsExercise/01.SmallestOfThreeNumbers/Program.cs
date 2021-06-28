using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = GetBiggestNumber(a, b, c);
            Console.WriteLine(result);
        }

        private static int GetBiggestNumber(int a, int b, int c)
        {
            return Math.Min(c, Math.Min(a, b));
        }
    }
}
