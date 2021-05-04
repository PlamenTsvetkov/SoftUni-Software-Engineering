using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            double minuteWalk = double.Parse(Console.ReadLine());
            int numWalk = int.Parse(Console.ReadLine());
            double catCalories = double.Parse(Console.ReadLine());

            double totalMinute = minuteWalk * numWalk;
            double burnCalories = totalMinute * 5;
            double percenet = catCalories * 0.5;

            if (percenet <= burnCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCalories}.");
            }
        }
    }
}
