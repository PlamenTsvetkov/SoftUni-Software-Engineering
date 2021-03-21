using System;

namespace _02SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string time = Console.ReadLine().ToLower();
            
            string outfit = "";
            string shoes = "";

            if (10<=degrees && degrees <=18)
            {
                if (time == "morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time == "afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18 < degrees && degrees <= 24)
            {
                if (time == "morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (25 <= degrees)
            {
                if (time == "morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (time == "evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
