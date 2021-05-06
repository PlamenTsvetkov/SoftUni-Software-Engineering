using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double currentBiscuit = 0;
            double totalBiscuit = 0;
            double eatFood = 0;
            double totalEatCat=0;
            double totalEatDog = 0;

            for (int i = 1; i <= day; i++)
            {
                double eatDog = double.Parse(Console.ReadLine());
                eatFood += eatDog;
                totalEatDog += eatDog;
              double eatCat = double.Parse(Console.ReadLine());
                eatFood += eatCat;
                totalEatCat += eatCat;
                if (i%3==0)
                {
                   currentBiscuit = (eatCat + eatDog) * 0.1;
                    totalBiscuit += currentBiscuit;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuit)}gr.");
            Console.WriteLine($"{eatFood/totalFood*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalEatDog / eatFood * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{totalEatCat / eatFood * 100:f2}% eaten from the cat.");
        }
    }
}
