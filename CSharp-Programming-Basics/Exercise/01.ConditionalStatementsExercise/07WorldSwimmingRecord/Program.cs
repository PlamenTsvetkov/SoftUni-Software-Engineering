using System;

namespace _07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double metri = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double zabava = Math.Floor(metri / 15) * 12.5;
            double vreme = metri * time;

            double totalTime = zabava + vreme;
            double razlika =  totalTime - record;

            
            if (razlika < 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {razlika:F2} seconds slower.");
            }

        }
    }
}
