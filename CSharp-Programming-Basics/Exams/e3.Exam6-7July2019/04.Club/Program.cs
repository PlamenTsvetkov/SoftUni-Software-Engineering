using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());
            string nameCocktail = "";
            int numCocktail = 0;


            int price = 0;
            double totalPrice = 0.00;
            double allSum = 0.00;
            while (profit>allSum)
            {
                 nameCocktail = Console.ReadLine();
                if (nameCocktail == "Party!")
                {
                    Console.WriteLine($"We need {profit-allSum:F2} leva more.");
                    break;
                }
                price = nameCocktail.Length;
                 numCocktail = int.Parse(Console.ReadLine());
                totalPrice = price * numCocktail;
                
                if (totalPrice%2!=0)
                {
                    totalPrice = totalPrice * 0.75;
                }
                allSum += totalPrice;
            }
            if (profit<=allSum)
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {allSum:F2} leva.");
            
            
        }
    }
}
