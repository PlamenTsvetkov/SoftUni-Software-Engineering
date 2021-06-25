using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintTotalPrice(typeProduct, quantity);
        }

        private static void PrintTotalPrice(string typeProduct, int quantity)
        {
            double price = 0;
            double result = 0;
            if (typeProduct=="coffee")
            {
                price = 1.50;
                result = quantity * price;
                Console.WriteLine($"{result:f2}");
            }
            else if (typeProduct == "water")
            {
                price = 1.00;
                result = quantity * price;
                Console.WriteLine($"{result:f2}");
            }
            else if (typeProduct == "coke")
            {
                price = 1.40;
                result = quantity * price;
                Console.WriteLine($"{result:f2}");
            }
            else if (typeProduct == "snacks")
            {
                price = 2.00;
                result = quantity * price;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
