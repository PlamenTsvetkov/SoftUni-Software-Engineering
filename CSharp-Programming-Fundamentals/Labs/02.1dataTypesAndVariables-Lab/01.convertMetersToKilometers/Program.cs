using System;

namespace _01.convertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometres = meters / 1000.0M;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
