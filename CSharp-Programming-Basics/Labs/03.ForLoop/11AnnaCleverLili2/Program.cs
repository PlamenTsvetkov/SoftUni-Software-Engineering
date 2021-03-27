using System;

namespace _11AnnaCleverLili2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toyQuantity = 0;
            int money = 0;
            int moneyBrother = 0;
            double totalMoney = 0.00;
            double moneyFromToys = 0.00;
            double diffn = 0.00;


            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    toyQuantity += 1;

                }
                if (i % 2 != 0)
                {
                    money += i / 2 * 10 + 10;
                    moneyBrother += 1;
                }

            }
            moneyFromToys = toyQuantity * toysPrice;
            totalMoney = money - moneyBrother + moneyFromToys;
            diffn = totalMoney - pPrice;
            double diffm = pPrice - totalMoney;


            if (totalMoney >= pPrice)
            {
                Console.WriteLine($"Yes! {diffn:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diffm:F2}");
            }
        }
    }
}
