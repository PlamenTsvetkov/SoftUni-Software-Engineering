using System;

namespace _05.AnaTraveling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double money = 0.00;

            double saveMoney = 0.00;

            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double minBudget = double.Parse(Console.ReadLine());
                while (saveMoney<minBudget)
                {
                     money = double.Parse(Console.ReadLine());
                    saveMoney += money;
                }
                Console.WriteLine($"Going to { destination}!");
                saveMoney = 0;
            }
            
        }
    }
}
