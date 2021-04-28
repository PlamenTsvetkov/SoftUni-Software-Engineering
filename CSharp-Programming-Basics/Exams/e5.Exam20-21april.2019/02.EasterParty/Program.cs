using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityGuests = int.Parse(Console.ReadLine());
            double couvertPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double couvertTotalPrice = 0;
            if (quantityGuests >=10 && quantityGuests<=15)
            {
                couvertTotalPrice = quantityGuests * couvertPrice * 0.85;
            }
            else if (quantityGuests > 15 && quantityGuests <= 20)
                {
                couvertTotalPrice = quantityGuests * couvertPrice * 0.80;
                }
            else if (quantityGuests > 20)
            {
                couvertTotalPrice = quantityGuests * couvertPrice * 0.75;
            }
            if (quantityGuests < 10)
            {
                couvertTotalPrice = quantityGuests * couvertPrice;
            }
            double cakePrice = budget * 0.10;
            double totalExpenses = cakePrice + couvertTotalPrice;
            if (budget>=totalExpenses)
            {
                Console.WriteLine($"It is party time! {budget-totalExpenses:f2} leva left.");
            }
            else if (budget<totalExpenses)
            {
                Console.WriteLine($"No party! {totalExpenses-budget:f2} leva needed.");
            }
            
        }
    }
}
