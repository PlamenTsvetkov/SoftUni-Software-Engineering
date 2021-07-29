using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, PriceStock> products = new Dictionary<string, PriceStock>();
            while ((input = Console.ReadLine())!="buy")
            {
                List<string> product = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!products.ContainsKey(product[0]))
                {
                    PriceStock priceStock = new PriceStock(double.Parse(product[1]), int.Parse(product[2]));
                    products.Add(product[0], priceStock);
                }
                else
                {
                    products[product[0]].Stock += int.Parse(product[2]);
                    products[product[0]].Price = double.Parse(product[1]);
                }

            }
            foreach (var pair in products)
            {
                Console.WriteLine($"{pair.Key} -> {products[pair.Key].Stock * products[pair.Key].Price:f2}");
            }
         
        }
        class PriceStock
        {
            public double Price { get; set; }
            public int Stock { get; set; }
            public PriceStock(double price, int stock )
            {
                this.Price = price;
                this.Stock = stock;
            }
        }
    }
}
