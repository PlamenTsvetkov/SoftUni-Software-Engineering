using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double prise = 0;
            if (date=="21-23")
            {
                if (destination=="France")
                {
                    prise = 30;
                }
                else if (destination == "Italy")
                {
                    prise = 28;
                }
                else if (destination == "Germany")
                {
                    prise = 32;
                }
            }
            else if (date == "24-27")
            {
                if (destination == "France")
                {
                    prise = 35;
                }
                else if (destination == "Italy")
                {
                    prise = 32;
                }
                else if (destination == "Germany")
                {
                    prise = 37;
                }
            }
            else if (date == "28-31")
            {
                if (destination == "France")
                {
                    prise = 40;
                }
                else if (destination == "Italy")
                {
                    prise = 39;
                }
                else if (destination == "Germany")
                {
                    prise = 43;
                }
            }
            double totalExpenses = nights * prise;
            Console.WriteLine($"Easter trip to {destination} : {totalExpenses:f2} leva.");
        }
    }
}
