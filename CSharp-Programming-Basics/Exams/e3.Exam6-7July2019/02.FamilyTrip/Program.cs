using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percentExpenses = int.Parse(Console.ReadLine());

            if (nights>7)
            {
                nightPrice = nightPrice * 0.95;
            }
            double additionalCosts = budget * percentExpenses / 100;
            double totalExpenses = (nights * nightPrice) + additionalCosts;
            if (budget>= totalExpenses)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-totalExpenses:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalExpenses-budget:F2} leva needed.");
            }
        }
    }
}
