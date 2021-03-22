using System;

namespace _05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string distination = "";
            string holiday = "";
            double sum = 0.00;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    distination = "Bulgaria";
                    sum = budget * 0.3;
                }
                else if (season == "winter")
                {
                    distination = "Bulgaria";
                    sum = budget * 0.7;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    distination = "Balkans";
                    sum = budget * 0.4;
                }
                else if (season == "winter")
                {
                    distination = "Balkans";
                    sum = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                if (season == "summer" || season =="winter")
                {
                    distination = "Europe";
                    sum = budget * 0.9;
                }
            }
            if (season =="summer" && distination!="Europe")
            {
                holiday = "Camp";
            }
            else if (season == "winter" && distination != "Europe")
            {
                holiday = "Hotel";
            }
            else if (distination == "Europe")
            {
                holiday = "Hotel";
            }
            Console.WriteLine($"Somewhere in {distination}");
            Console.WriteLine($"{holiday} - {sum:F2}");
        }
    }
}
