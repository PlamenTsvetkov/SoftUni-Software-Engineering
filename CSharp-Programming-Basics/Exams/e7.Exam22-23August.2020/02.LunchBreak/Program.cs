using System;

namespace _02.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            double timeEpizod = double.Parse(Console.ReadLine());
            double stop = double.Parse(Console.ReadLine());

            double timeLunch = stop * 1 / 8;
            double timeRelax = stop * 1 / 4;
            double freeTime = stop - timeLunch - timeRelax;

            if (freeTime>=timeEpizod)
            {
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(freeTime-timeEpizod)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(timeEpizod-freeTime)} more minutes.");
            }
        }
    }
}
