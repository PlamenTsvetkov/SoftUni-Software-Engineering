using System;

namespace _05Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes < 45)
            {
                minutes += 15;
            }
            else if ( minutes >= 45 && hours < 23)
            {
                hours += 1;
                minutes -= 45;
            }
            else if (minutes >=45 && hours ==23)
            {
                hours = 0;
                minutes -= 45;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
