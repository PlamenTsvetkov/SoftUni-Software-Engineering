using System;

namespace _01.OscarCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double statue = rent * 0.70;
            double catering = statue * 0.85;
            double sound = catering * 1 / 2;
            double totalExpenses = rent + statue + catering + sound;
            Console.WriteLine($"{ totalExpenses:F2}");
           
        }
    }
}
