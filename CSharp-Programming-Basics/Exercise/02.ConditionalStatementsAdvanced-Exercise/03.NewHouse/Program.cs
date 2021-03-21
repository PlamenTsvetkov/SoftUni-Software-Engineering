using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalSumFlawer = 0.00;
            double price = 0.00;

            if (type == "Roses")
            {
                price = 5;
                if (quantity >80)
                {
                    totalSumFlawer = quantity * price * 0.9;
                }
                else
                {
                    totalSumFlawer = quantity * price;
                }
            }
            else if (type == "Dahlias")
            {
                price = 3.80;
                if (quantity > 90)
                {
                    totalSumFlawer = quantity * price * 0.85;
                }
                else
                {
                    totalSumFlawer = quantity * price;
                }
            }
            else if (type == "Tulips")
            {
                price = 2.80;
                if (quantity > 80)
                {
                    totalSumFlawer = quantity * price * 0.85;
                }
                else
                {
                    totalSumFlawer = quantity * price;
                }
            }
            else if (type == "Narcissus")
            {
                price = 3.00;
                if (quantity < 120)
                {
                    totalSumFlawer = quantity * price * 1.15;
                }
                else
                {
                    totalSumFlawer = quantity * price;
                }
            }
            else if (type == "Gladiolus")
            {
                price = 2.50;
                if (quantity < 80)
                {
                    totalSumFlawer = quantity * price * 1.20;
                }
                else
                {
                    totalSumFlawer = quantity * price;
                }
            }
           
            
            if (budget-totalSumFlawer > 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {budget - totalSumFlawer:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need { Math.Abs(budget - totalSumFlawer):F2} leva more.");   
            }            
        }
    }
}
