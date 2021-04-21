using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double rocketPrice = double.Parse(Console.ReadLine());
            int rocketQuantity = int.Parse(Console.ReadLine());
            int sneakersQuantity = int.Parse(Console.ReadLine());

            double sneakersPrice = rocketPrice / 6;
            
            double price = rocketPrice * rocketQuantity + sneakersPrice * sneakersQuantity;
            double other = price * 0.20;
            double totalPrice = price + other;
            double djokovichPrice = totalPrice * 1 / 8;
            double sponsorPrice = totalPrice * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djokovichPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sponsorPrice)}");
        }
    }
}
