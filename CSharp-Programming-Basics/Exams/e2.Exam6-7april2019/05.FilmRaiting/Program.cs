using System;

namespace _05.FilmRaiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int filmNum = int.Parse(Console.ReadLine());

            double minRaiting = int.MaxValue;
            double maxRaiting = int.MinValue;
            double sumRaiting = 0.00;
            string filmMinRaiting = "";
            string filmMaxRaiting = "";

            for (int i = 0; i < filmNum; i++)
            {
                string filmName = Console.ReadLine();
                double filmRaiting = double.Parse(Console.ReadLine());
                sumRaiting += filmRaiting;
                if (filmRaiting>maxRaiting)
                {
                    maxRaiting = filmRaiting;
                    filmMaxRaiting = filmName;
                }
                if (filmRaiting<minRaiting)
                {
                    minRaiting = filmRaiting;
                    filmMinRaiting = filmName;
                }
            }
            double averageRaiting = sumRaiting / filmNum;
            
            Console.WriteLine($"{filmMaxRaiting} is with highest rating: {maxRaiting:f1}");
            Console.WriteLine($"{filmMinRaiting} is with lowest rating: {minRaiting:f1}");
            Console.WriteLine($"Average rating: {averageRaiting:f1}");
        }
    }
}
