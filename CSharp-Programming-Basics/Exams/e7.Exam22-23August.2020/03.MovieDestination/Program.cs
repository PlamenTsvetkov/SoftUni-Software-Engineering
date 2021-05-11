using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());

            double prize = 0.00;

            if (season=="Winter")
            {
                if (destination=="Dubai")
                {
                    prize = 45000;
                }
                else if (destination == "Sofia")
                {
                    prize = 17000;
                }
                else if (destination == "London")
                {
                    prize = 24000;
                }
            }
            else if (season == "Summer")
            {
                if (destination == "Dubai")
                {
                    prize = 40000;
                }
                else if (destination == "Sofia")
                {
                    prize = 12500;
                }
                else if (destination == "London")
                {
                    prize = 20250;
                }
            }
            double totalPrize = prize * days;
            if (destination=="Dubai")
            {
                totalPrize = totalPrize * 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrize = totalPrize * 1.25;
            }
            if (budget>=totalPrize)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-totalPrize:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrize-budget:f2} leva more!");
            }
        }
    }
}
