using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
           double a =double.Parse(Console.ReadLine());
           double b =double.Parse(Console.ReadLine());
            double result = GetPow(a, b);
            Console.WriteLine(result);
        }

        private static double GetPow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
