using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double totalPriceWithoutTax = 0;
            while ((input = Console.ReadLine()) != "special")
            {
                if (input== "regular")
                {
                    break;
                }
                double currentPrice = double.Parse(input);
                if (currentPrice<0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWithoutTax += currentPrice;
            }
            double tax = totalPriceWithoutTax * 0.2;
            double totalPriceWithTax = totalPriceWithoutTax + tax;
            if (input == "special")
            {
                totalPriceWithTax *= 0.9;
            }
            if (totalPriceWithTax==0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPriceWithTax:f2}$");
            }

        }
    }
}
