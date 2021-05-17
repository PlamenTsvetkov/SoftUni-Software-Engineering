using System;

namespace _04
{
    class catFood
    {
        static void Main(string[] args)
        {
            double foodPrice = 12.45;
            double catQuantity = double.Parse(Console.ReadLine());
            int littleCat = 0;
            int bigCat = 0;
            int hugeCat = 0;
            double totalGrFood = 0;
            for (int i = 0; i < catQuantity; i++)
            {
                int grFood = int.Parse(Console.ReadLine());
                totalGrFood += grFood;
                if (100<=grFood && grFood<200)
                {
                    littleCat++;
                }
                else if (200 <= grFood && grFood < 300)
                {
                    bigCat++;
                }
                else if (300 <= grFood && grFood < 400)
                {
                    hugeCat++;
                }

            }
            double totalKgFood = totalGrFood / 1000;
            double totalPrice = totalKgFood * foodPrice;
            Console.WriteLine($"Group 1: {littleCat} cats.");
            Console.WriteLine($"Group 2: {bigCat} cats.");
            Console.WriteLine($"Group 3: {hugeCat} cats.");
            Console.WriteLine($"Price for food per day: {totalPrice:f2} lv.");
        }
    }
}
