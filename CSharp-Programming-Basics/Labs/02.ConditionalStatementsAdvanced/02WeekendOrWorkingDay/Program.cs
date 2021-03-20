using System;

namespace _02WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                Console.WriteLine("Working day");
            }
            else if (day == "sunday" || day == "saturday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
