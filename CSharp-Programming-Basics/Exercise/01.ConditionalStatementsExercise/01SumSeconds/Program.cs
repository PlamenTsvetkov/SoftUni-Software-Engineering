using System;

namespace _01SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firsTime + secondTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds:D2}");
            }
            
        }
    }
}
