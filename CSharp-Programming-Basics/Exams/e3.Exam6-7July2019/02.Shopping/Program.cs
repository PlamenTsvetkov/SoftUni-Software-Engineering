using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            
            double videocardsPrice = 250;
            double totalSum = 0;

            
            double videocardsSum = videocards * videocardsPrice;
            double procesorsSum = procesors * (videocardsSum* 0.35);
            double ramSum = ram * (videocardsSum * 0.10);
            if (videocards > procesors)
            {
                 totalSum = (videocardsSum + procesorsSum + ramSum) * 0.85;
            }
            else
            {
                totalSum = (videocardsSum + procesorsSum + ramSum);
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalSum - budget):F2} leva more!");
            }

        }
    }
}
