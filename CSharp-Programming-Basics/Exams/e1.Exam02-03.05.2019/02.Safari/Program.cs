using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelL = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double fuelPrice = 2.10;
            double fuelTotalPrice = fuelL * fuelPrice;            
            double gidPrice = 100;
            double totalSum = fuelTotalPrice +gidPrice;
            if (day == "Saturday")
            {
                totalSum = totalSum * 0.90;
            }
            else if (day == "Sunday")
            {
                totalSum = totalSum * 0.80;
            }
            if (budget>=totalSum)
            {
                Console.WriteLine($"Safari time! Money left: {budget-totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalSum-budget:f2} lv.");
            }

        }
    }
}
