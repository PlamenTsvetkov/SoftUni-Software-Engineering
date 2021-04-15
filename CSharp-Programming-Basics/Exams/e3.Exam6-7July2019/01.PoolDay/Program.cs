using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double deskChairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double totalUmbrella = Math.Ceiling(peopleNum / 2.0);
            double totalDeskChair = Math.Ceiling(peopleNum * 0.75);


            double totalFee = peopleNum * fee;
            double totalUmbrellaPrice =  totalUmbrella* umbrellaPrice;
            double totalDeskChairPrice = totalDeskChair * deskChairPrice;

            double totalSum = totalFee + totalUmbrellaPrice + totalDeskChairPrice;
            Console.WriteLine($"{totalSum:F2} lv.");

        }
    }
}
