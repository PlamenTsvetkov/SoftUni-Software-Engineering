using System;

namespace _02.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hourWork = int.Parse(Console.ReadLine());

            double totalPaintPrice = paint * 1.10 * 14.50;
            double totalNailonPrice = (nailon + 2) * 1.50;
            double totalRazreditelPrice = razreditel * 5;

            double totalExpensesForMaterial = totalPaintPrice + totalNailonPrice + totalRazreditelPrice + 0.40;
            double totalPriceWork = totalExpensesForMaterial * 0.30*hourWork;
            double total = totalExpensesForMaterial + totalPriceWork;
            Console.WriteLine($"Total expenses: {total:F2} lv.");

        }
    }
}
