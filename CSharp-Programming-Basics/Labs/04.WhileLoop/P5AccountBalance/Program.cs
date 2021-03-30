using System;

namespace _05.AnaAccountBalanceTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAmount = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if (amount <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {amount:F2}");
                totalAmount += amount;
                input = Console.ReadLine(); 
            }
            Console.WriteLine($"Total: {totalAmount:F2}");

        }
    }
}
