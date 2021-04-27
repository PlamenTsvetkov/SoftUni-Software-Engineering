using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityEasterBread = double.Parse(Console.ReadLine());
            double quantityEggs = double.Parse(Console.ReadLine());
            double qurabiiKg = double.Parse(Console.ReadLine());

            double easterBreadPrice = 3.20;
            double eggsPrice = 4.35;
            double qurabiiPrice = 5.40;
            double eggPaintPrice = 0.15;

            double totalEasterBread = quantityEasterBread * easterBreadPrice;
            double totalEggs = quantityEggs * eggsPrice;
            double totalQuarabii = qurabiiKg * qurabiiPrice;
            double paintEggs = quantityEggs * eggPaintPrice*12;
            double totalExpenses = totalEasterBread + totalEggs + totalQuarabii + paintEggs;
            Console.WriteLine($"{totalExpenses:f2}");
           

        }
    }
}
