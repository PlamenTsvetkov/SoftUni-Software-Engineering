using System;

namespace _9Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            double presents = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekend = 48 - h;
            double weekendPlay = weekend * 3 / 4;
            double presentPlay =presents * 2 / 3;

            double plays = weekendPlay + presentPlay + h;

            if (year == "normal")
            {
                Console.WriteLine(Math.Floor(plays)); 
            }
            else if (year=="leap")
            {
                Console.WriteLine(Math.Floor(plays*1.15));
            }
        }
    }
}
