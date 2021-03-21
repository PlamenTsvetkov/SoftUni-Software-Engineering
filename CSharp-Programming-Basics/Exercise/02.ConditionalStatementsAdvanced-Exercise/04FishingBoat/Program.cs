using System;

namespace _04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double fisherman = double.Parse(Console.ReadLine());

            double rent = 0.00;

            if (fisherman <= 6)
            {
                if (season == "spring")
                {
                    rent = 3000 * 0.9;
                }
                else if (season == "summer")
                {
                    rent = 4200 * 0.9;
                }
                else if (season == "autumn")
                {
                    rent = 4200 * 0.9;
                }
                else if (season == "winter")
                {
                    rent = 2600 * 0.9;
                }

            }
            else if (7 < fisherman && fisherman <= 11)
            {
                if (season == "spring")
                {
                    rent = 3000 * 0.85;
                }
                else if (season == "summer")
                {
                    rent = 4200 * 0.85;
                }
                else if (season == "autumn")
                {
                    rent = 4200 * 0.85;
                }
                else if (season == "winter")
                {
                    rent = 2600 * 0.85;
                }
            }
            else if (fisherman >= 12)
            {
                if (season == "spring")
                {
                    rent = 3000 * 0.75;
                }
                else if (season == "summer")
                {
                    rent = 4200 * 0.75;
                }
                else if (season == "autumn")
                {
                    rent = 4200 * 0.75;
                }
                else if (season == "winter")
                {
                    rent = 2600 * 0.75;
                }
            }
        if (fisherman % 2 == 0 && season != "autumn")
        {
                    if (season == "spring")
                    {
                        rent = rent * 0.95;
                    }
                    else if (season == "summer")
                    {
                        rent = rent * 0.95;
                    }

                    else if (season == "winter")
                    {
                        rent = rent * 0.95;
                    }
        }
                if (budget>=rent)
                {
                    Console.WriteLine($"Yes! You have {budget-rent:F2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {Math.Abs(budget-rent):F2} leva.");
                }
        }
    }
}
