using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int loose = 0;
            int drow = 0;

            for (int i = 0; i < 3; i++)
            {
                string mach = Console.ReadLine();
                char score1 = mach[0];
                char score2 = mach[2];
                if (score1>score2)
                {
                    win++;
                }
                else if (score1 < score2)
                {
                    loose++;
                }
                else if (score1 == score2)
                {
                    drow++;
                }
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {loose} games.");
            Console.WriteLine($"Drawn games: {drow}");
        }
    }
}
