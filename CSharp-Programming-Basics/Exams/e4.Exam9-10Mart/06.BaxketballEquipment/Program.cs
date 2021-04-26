using System;

namespace _06.BaxketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = "";
            int matchNum = 0;
            int dt = 0;
            int ot = 0;
            double totalMatch = 0.00;
            double winMatch = 0.00;
            double looseMatch = 0.00;
            while ((tournamentName = Console.ReadLine()) != "End of tournaments")
            {
                matchNum = int.Parse(Console.ReadLine());
                totalMatch += matchNum;
                for (int i = 1; i <= matchNum; i++)
                {
                    dt = int.Parse(Console.ReadLine());
                    ot = int.Parse(Console.ReadLine());
                    if (dt > ot)
                    {
                        winMatch += 1;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {dt - ot} points.");
                    }
                    else
                    {
                        looseMatch += 1;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {ot - dt} points.");
                    }
                }
            }
            double winPercent = winMatch / totalMatch * 100;
            double loosePercent = looseMatch / totalMatch * 100;
            Console.WriteLine($"{winPercent:f2}% matches win");
            Console.WriteLine($"{loosePercent:f2}% matches lost");
            
        }
    }
}
