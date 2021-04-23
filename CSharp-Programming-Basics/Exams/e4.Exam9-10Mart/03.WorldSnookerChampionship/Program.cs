using System;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string round = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int quantityTicket = int.Parse(Console.ReadLine());
            char photoTrophey = char.Parse(Console.ReadLine());

            double price = 0.00;
            double totalSum = 0.00;

            if (round == "Quarter final")
            {
                if (typeTicket=="Standard")
                {
                    price = 55.50;
                }
                else if (typeTicket == "Premium")
                {
                    price = 105.20;
                }
                else if (typeTicket == "VIP")
                {
                    price = 118.90;
                }
            }
            else if (round == "Semi final")
            {
                if (typeTicket == "Standard")
                {
                    price = 75.88;
                }
                else if (typeTicket == "Premium")
                {
                    price = 125.22;
                }
                else if (typeTicket == "VIP")
                {
                    price = 300.40;
                }
            }
            else if (round == "Final")
            {
                if (typeTicket == "Standard")
                {
                    price = 110.10;
                }
                else if (typeTicket == "Premium")
                {
                    price = 160.66;
                }
                else if (typeTicket == "VIP")
                {
                    price = 400.00;
                }
            }
            totalSum = quantityTicket * price;
            if (totalSum>4000)
            {
                totalSum = totalSum * 0.75;
            }
            else if (totalSum>2500 && totalSum<=4000)
            {
                totalSum = totalSum * 0.90;
                if (photoTrophey=='Y')
                {
                    totalSum +=  40*quantityTicket;
                }
            }
            else
            {
                totalSum = quantityTicket * price;
                if (photoTrophey == 'Y')
                {
                    totalSum += 40*quantityTicket;
                }
            }
            Console.WriteLine($"{totalSum:F2}");
            
        }
    }
}
