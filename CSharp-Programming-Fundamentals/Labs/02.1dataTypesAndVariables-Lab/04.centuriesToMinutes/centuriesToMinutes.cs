using System;

namespace _04.centuriesToMinutes
{
    class centuriesToMinutes
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int year = centuries * 100;
            int days = (int)(year * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine($"{centuries} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
