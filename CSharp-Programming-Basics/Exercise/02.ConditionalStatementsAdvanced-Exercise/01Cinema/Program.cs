using System;

namespace _01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double rows = double.Parse(Console.ReadLine());
            double column = double.Parse(Console.ReadLine());

            double totalChair = rows * column;
            double price = 0.00;
            

            if (type =="premiere")
            {
                price = 12.00;
                double totalSum = totalChair * price;
                Console.WriteLine($"{totalSum:F2} leva");
            }
            else if (type == "normal")
            {
                price = 7.50;
                double totalSum = totalChair * price;
                Console.WriteLine($"{totalSum:F2} leva");
            }
            else if (type == "discount")
            {
                price = 5.00;
                double totalSum = totalChair * price;
                Console.WriteLine($"{totalSum:F2} leva");
            }
        }
    }
}
