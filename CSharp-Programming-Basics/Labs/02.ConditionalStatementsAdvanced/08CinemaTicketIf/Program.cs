using System;

namespace _08CinemaTicketIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();

            if (day == "monday")
            {
                Console.WriteLine(12);
            }
            else if (day == "tuesday")
            {
                Console.WriteLine(12);
            }
            else if (day == "wednesday")
            {
                Console.WriteLine(14);
            }
            else if (day == "thursday")
            {
                Console.WriteLine(14);
            }
            else if (day == "friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "saturday")
            {
                Console.WriteLine(16);
            }
            else if (day == "sunday")
            {
                Console.WriteLine(16);
            }
            else 
            {
                Console.WriteLine("Error");
            }
        }
    }
}
