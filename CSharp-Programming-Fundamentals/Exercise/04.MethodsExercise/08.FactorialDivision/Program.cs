using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            FactorialDivision(a, b);
        }

        private static void FactorialDivision(double a, double b)
        {
            double sumFactorialA = 1;
            double sumFactorialB = 1;
            for (int i = 1; i <= a; i++)
            {
                sumFactorialA *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                sumFactorialB *= i;
            }
            double result = sumFactorialA / sumFactorialB;
            Console.WriteLine($"{result:f2}");
        }
    }
}
