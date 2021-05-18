using System;

namespace _06
{
    class goldMine
    {
        static void Main(string[] args)
        {
            int locationNumber = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < locationNumber; i++)
            {
                double totalGoldMined = 0;
                double averageTargetPerDay = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int j = 0; j < days; j++)
                {
                    double goldMinedPerDay = double.Parse(Console.ReadLine());
                    totalGoldMined += goldMinedPerDay;
                }
                double averageGoldPerDay = totalGoldMined / days;
                if (averageGoldPerDay>=averageTargetPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {averageTargetPerDay-averageGoldPerDay:f2} gold.");
                }
            }
        }
    }
}
