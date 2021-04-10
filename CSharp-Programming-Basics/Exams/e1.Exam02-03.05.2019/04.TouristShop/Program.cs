using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameProduct = "";
            double productPrice = 0.00;
            int totalProduct = 0;
            double totalSum = 0.00;
            bool isValid = false;
            while ((nameProduct=Console.ReadLine())!="Stop")
            {
                productPrice =double.Parse(Console.ReadLine());
                totalProduct += 1;
                if (totalProduct%3==0)
                {
                    productPrice = productPrice * 1 / 2;
                }
                if (productPrice+totalSum>budget)
                {
                    isValid = true;
                    break;
                }
                totalSum += productPrice;

            }
            if (isValid)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(totalSum+productPrice-budget):f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {totalProduct} products for {totalSum:f2} leva.");
            }
        }
    }
}
