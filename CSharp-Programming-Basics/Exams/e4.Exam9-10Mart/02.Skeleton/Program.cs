using System;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double minuteControl = double.Parse(Console.ReadLine());
            double secondControl = double.Parse(Console.ReadLine());
            double lenght=double.Parse(Console.ReadLine());
            double secondFor100m = double.Parse(Console.ReadLine());

            double totalControl = minuteControl * 60 + secondControl;
            double minus = lenght / 120;
            double minusTime = minus * 2.5;
            double timeMarin = (lenght / 100) * secondFor100m - minusTime;
            if (timeMarin<=totalControl)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(totalControl-timeMarin):f3} second slower.");
            }

        }
    }
}
