using System;

namespace _03.AnaVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int totalDays = 0;
            bool saveMoney = false;
            while (true)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                totalDays += 1;
                if (action == "spend")
                {
                    if (sum>money)
                    {
                        money = 0;
                    }
                    else
                    {
                        money -= sum;
                    }
                    
                    spendCounter += 1;
                }
                else if (action == "save")
                {
                    money += sum;
                    spendCounter = 0;
                }
                if (spendCounter ==5)
                {
                    saveMoney = false;
                    break;
                }
                if (holidayPrice <= money)
                {
                    saveMoney = true;
                    break;
                }

            }
            if (saveMoney)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            
        }
    }
}
