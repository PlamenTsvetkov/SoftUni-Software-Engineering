using System;

namespace _07WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string day = Console.ReadLine().ToLower();

            if (hour>=10 && hour <=16)
            {
                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday" || day =="saturday")
                {
                    Console.WriteLine("open");
                }
                else 
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
