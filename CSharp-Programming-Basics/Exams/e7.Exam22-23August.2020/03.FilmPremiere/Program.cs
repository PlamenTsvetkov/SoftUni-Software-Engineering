using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string packet = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double prize = 0.00;

            if (film=="John Wick")
            {
                if (packet=="Drink")
                {
                    prize = 12;
                }
                else if (packet == "Popcorn")
                {
                    prize = 15;
                }
                else if (packet == "Menu")
                {
                    prize = 19;
                }
            }
            else if (film == "Star Wars")
            {
                if (packet == "Drink")
                {
                    prize = 18;
                }
                else if (packet == "Popcorn")
                {
                    prize = 25;
                }
                else if (packet == "Menu")
                {
                    prize = 30;
                }
            }
            else if (film == "Jumanji")
            {
                if (packet == "Drink")
                {
                    prize = 9;
                }
                else if (packet == "Popcorn")
                {
                    prize = 11;
                }
                else if (packet == "Menu")
                {
                    prize = 14;
                }
            }
            double totalPrize = prize * quantity;
            if (film == "Star Wars" && quantity>=4)
            {
                totalPrize = totalPrize * 0.7;
            }
            else if (film == "Jumanji" && quantity == 2)
            {
                totalPrize = totalPrize * 0.85;
            }
            Console.WriteLine($"Your bill is {totalPrize:f2} leva.");
        }
    }
}
