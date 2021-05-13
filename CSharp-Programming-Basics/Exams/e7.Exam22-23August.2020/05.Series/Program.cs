using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                string nameSerial = Console.ReadLine();
                double filmPrice = double.Parse(Console.ReadLine());
                if (nameSerial=="Thrones")
                {
                    filmPrice = filmPrice * 0.5;
                }
                else if (nameSerial == "Lucifer")
                {
                    filmPrice = filmPrice * 0.60;
                }
                else if (nameSerial == "Protector")
                {
                    filmPrice = filmPrice * 0.70;
                }
                else if (nameSerial == "TotalDrama")
                {
                    filmPrice = filmPrice * 0.80;
                }
                else if (nameSerial == "Area")
                {
                    filmPrice = filmPrice * 0.90;
                }
                totalSum += filmPrice;
            }
            if (budget>=totalSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget-totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {totalSum-budget:f2} lv. more to buy the series!"
);
            }
        }
    }
}
