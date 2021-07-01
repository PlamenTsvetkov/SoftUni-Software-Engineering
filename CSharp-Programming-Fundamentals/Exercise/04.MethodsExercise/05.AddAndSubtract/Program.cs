using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SumAB(a, b,c);
        }

        private static void  SumAB(int a, int b, int c)
        {
            Console.WriteLine((a + b) - c);
        }
    }
}
