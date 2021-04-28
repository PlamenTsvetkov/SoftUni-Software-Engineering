using System;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityGuests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double quantityEasterBread = Math.Ceiling(quantityGuests / 3);
            double quantityEggs = quantityGuests * 2;

            double priceEasterBread = 4;
            double priceEggs = 0.45;

            double totalExpenses = quantityEasterBread * priceEasterBread + quantityEggs * priceEggs;
            if (budget>=totalExpenses)
            {
                Console.WriteLine($"Lyubo bought {quantityEasterBread} Easter bread and {quantityEggs} eggs.");
                Console.WriteLine($"He has {budget-totalExpenses:f2} lv. left.");
            }
            else if (budget<totalExpenses)
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalExpenses-budget:f2} lv. more.");
            }
        }
    }
}
