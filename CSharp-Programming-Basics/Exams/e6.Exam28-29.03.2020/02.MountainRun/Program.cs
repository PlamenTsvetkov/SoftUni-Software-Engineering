using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double secondRecords = double.Parse(Console.ReadLine());
            double crossMetre = double.Parse(Console.ReadLine());
            double timeForMetre = double.Parse(Console.ReadLine());

            double otherSeconds = 0;
            double otherFlood = Math.Floor(crossMetre / 50);
            otherSeconds = otherFlood * 30;
            double seconds = crossMetre * timeForMetre;
            double totalSeconds = seconds + otherSeconds;
            if (totalSeconds<secondRecords)
            {
                Console.WriteLine($"Yes! The new record is {totalSeconds:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(secondRecords-totalSeconds):f2} seconds slower.");
            }
        }
    }
}
