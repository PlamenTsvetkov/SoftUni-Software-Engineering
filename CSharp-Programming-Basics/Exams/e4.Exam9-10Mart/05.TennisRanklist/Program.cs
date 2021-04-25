using System;

namespace _05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityTournaments = double.Parse(Console.ReadLine());
            double startPoint = double.Parse(Console.ReadLine());

            int tournamentWins = 0;
            double totalPoint = 0;
            for (int i = 0; i < quantityTournaments; i++)
            {
                string result = Console.ReadLine();
                if (result =="W")
                {
                    startPoint += 2000;
                    totalPoint += 2000;
                    tournamentWins += 1;
                }
                else if (result == "F")
                {
                    startPoint += 1200;
                    totalPoint += 1200;
                }
                else if (result == "SF")
                {
                    startPoint += 720;
                    totalPoint += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoint}");
            Console.WriteLine($"Average points: {Math.Floor(totalPoint/quantityTournaments)}");
            Console.WriteLine($"{tournamentWins/quantityTournaments*100:F2}%");
        }
    }
}
