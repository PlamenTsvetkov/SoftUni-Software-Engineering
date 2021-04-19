using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            int point = 0;
            int w = 0;
            int d = 0;
            int l = 0;
            for (int i = 1; i <= games; i++)
            {
                string result = Console.ReadLine();
                if (result =="W")
                {
                    w += 1;
                    point += 3;
                }
                else if (result =="D")
                {
                    d += 1;
                    point += 1;
                }
                else if (result == "L")
                {
                    l += 1;
                }
            }
            if (games==0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{teamName} has won {point} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {w}");
                Console.WriteLine($"## D: {d}");
                Console.WriteLine($"## L: {l}");
                Console.WriteLine($"Win rate: {w* 1.0 /games*100:F2}%");
            }
        }
    }
}
