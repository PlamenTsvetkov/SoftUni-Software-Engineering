using System;

namespace _08.townInfo
{
    class townInfo
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {cityName} has population of {population} and area {area} square km.");
        }
    }
}
