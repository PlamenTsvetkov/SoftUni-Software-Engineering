using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double prize = 0.00;
            if (gender=="m")
            {
                if (sport =="Gym")
                {
                    prize = 42;
                }
                else if (sport == "Boxing")
                {
                    prize = 41;
                }
                else if (sport == "Yoga")
                {
                    prize = 45;
                }
                else if (sport == "Zumba")
                {
                    prize = 34;
                }
                else if (sport == "Dances")
                {
                    prize = 51;
                }
                else if (sport == "Pilates")
                {
                    prize = 39;
                }
            }
            else if (gender == "f")
            {
                if (sport == "Gym")
                {
                    prize = 35;
                }
                else if (sport == "Boxing")
                {
                    prize = 37;
                }
                else if (sport == "Yoga")
                {
                    prize = 42;
                }
                else if (sport == "Zumba")
                {
                    prize = 31;
                }
                else if (sport == "Dances")
                {
                    prize = 53;
                }
                else if (sport == "Pilates")
                {
                    prize = 37;
                }
            }
            if (age<=19)
            {
                prize = prize * 0.80;
            }
            if (budget>=prize)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${prize-budget:f2} more.");
            }
        }
    }
}
