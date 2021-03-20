using System;

namespace _07ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int dollNum = int.Parse(Console.ReadLine());
            int bearNum = int.Parse(Console.ReadLine());
            int minionNum = int.Parse(Console.ReadLine());
            int truckNum = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double puzzleSum = puzzleNum * puzzlePrice;
            double dollSum = dollNum * dollPrice;
            double bearSum = bearNum * bearPrice;
            double minionSum = minionNum * minionPrice;
            double truckSum = truckNum * truckPrice;

            double toyNum = puzzleNum + dollNum + bearNum + minionNum + truckNum;
            double totalSum = puzzleSum + dollSum + bearSum + minionSum + truckSum;

            if (toyNum >=50)
            {
                totalSum = totalSum - 0.25 * totalSum;
            }
            totalSum = totalSum - totalSum * 0.1;
            double finalSum = totalSum - tripPrice;

            if (totalSum >=tripPrice)
            {
                Console.WriteLine($"Yes! {finalSum:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(finalSum):F2} lv needed.");
            }


        }
    }
}
