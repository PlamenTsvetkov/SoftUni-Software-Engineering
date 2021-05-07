using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            double kgFood = double.Parse(Console.ReadLine());
            string isAdopted = "";
            double totalGrFood = kgFood * 1000;
            double totalEat = 0;
            while ((isAdopted=Console.ReadLine())!="Adopted")
            {
                int grFood = int.Parse(isAdopted);
                totalEat += grFood;
            }
            if (totalGrFood>=totalEat)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalGrFood-totalEat} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEat-totalGrFood} grams more.");
            }
        }
    }
}
