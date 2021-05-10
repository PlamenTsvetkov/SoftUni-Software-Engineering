using System;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double time = double.Parse(Console.ReadLine());
            double sceneNum = double.Parse(Console.ReadLine());
            double sceneTime = double.Parse(Console.ReadLine());

            double prepare = time * 0.15;
            double totalScenaTime = sceneNum * sceneTime;
            double totalTime = prepare + totalScenaTime;

            if (totalTime<= time)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time-totalTime,0)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {totalTime-time} minutes.");
            }


        }
    }
}
