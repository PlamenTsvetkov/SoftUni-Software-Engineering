using System;

namespace _03.EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double prize = 0.00;

            if (type=="small")
            {
                if (fruit=="Watermelon")
                {
                    prize = 2*56;
                }
                else if (fruit == "Mango")
                {
                    prize = 2*36.66;
                }
                else if (fruit == "Pineapple")
                {
                    prize = 2*42.10;
                }
                else if (fruit == "Raspberry")
                {
                    prize = 2*20;
                }
            }
            else if (type == "big")
            {
                if (fruit == "Watermelon")
                {
                    prize = 5*28.70;
                }
                else if (fruit == "Mango")
                {
                    prize = 5*19.60;
                }
                else if (fruit == "Pineapple")
                {
                    prize = 5*24.80;
                }
                else if (fruit == "Raspberry")
                {
                    prize = 5*15.20;
                }
            }
            double totalPrize = quantity * prize;
            if (totalPrize>=400 && totalPrize<=1000)
            {
                totalPrize = totalPrize * 0.85;
            }
            else if (totalPrize>1000)
            {
                totalPrize = totalPrize * 0.5;
            }
            Console.WriteLine($"{totalPrize:f2} lv.");
        }
    }
}
