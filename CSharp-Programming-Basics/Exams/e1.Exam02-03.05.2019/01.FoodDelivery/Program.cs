using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenQ = int.Parse(Console.ReadLine());
            int fishQ = int.Parse(Console.ReadLine());
            int veganQ = int.Parse(Console.ReadLine());

            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veganPrice = 8.15;
            double startTotalPrice = chickenPrice * chickenQ + fishPrice * fishQ + veganPrice * veganQ;
            double priceDesert = startTotalPrice * 0.2;
            double diliveryPrice = 2.50;
            double finishTotalPrice = startTotalPrice + priceDesert + diliveryPrice;
            Console.WriteLine($"Total: {finishTotalPrice:F2}");

        }
    }
}
