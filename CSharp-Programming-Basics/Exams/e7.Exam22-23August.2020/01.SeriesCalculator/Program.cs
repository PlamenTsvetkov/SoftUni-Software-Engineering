using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            double seasonNum = double.Parse(Console.ReadLine());
            double episodsNum = double.Parse(Console.ReadLine());
            double timeEpisod = double.Parse(Console.ReadLine());

            double advertisingTime = timeEpisod * 0.2;
            double specialEpizodTime = 10 * seasonNum;
            double timeEpizodAdvertising = advertisingTime + timeEpisod;
            double totalTimeAdvertising = timeEpizodAdvertising * episodsNum * seasonNum + specialEpizodTime;
            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {Math.Floor(totalTimeAdvertising)} minutes.");
        }
    }
}
