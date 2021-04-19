using System;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales = int.Parse(Console.ReadLine());

            int quantityHeartstone = 0;
            int quantityFornite = 0;
            int quantityOverwatch = 0;
            int quantityOthers = 0;

            for (int i = 1; i <= sales; i++)
            {
                string game = Console.ReadLine();
                if (game == "Hearthstone")
                {
                    quantityHeartstone += 1;
                }
                else if (game == "Fornite")
                {
                    quantityFornite += 1;
                }
                else if (game == "Overwatch")
                {
                    quantityOverwatch += 1;
                }
                else
                {
                    quantityOthers += 1;
                }
            }
            double HeartstonePercent = quantityHeartstone / sales * 100;
            double FornitePercent = quantityFornite / sales * 100;
            double OverwachPercent = quantityOverwatch / sales * 100;
            double otherPercent = quantityOthers / sales * 100;
            //Console.WriteLine(quantityHeartstone);
            //Console.WriteLine(quantityFornite);
            //Console.WriteLine(quantityOverwatch);
            //Console.WriteLine(quantityOthers);
            //Console.WriteLine(HeartstonePercent);
            //Console.WriteLine(FornitePercent);
            //Console.WriteLine(OverwachPercent);
            //Console.WriteLine(otherPercent);
            Console.WriteLine($"Hearthstone - {HeartstonePercent:F2}%");
            Console.WriteLine($"Fornite - {FornitePercent:F2}%");
            Console.WriteLine($"Overwatch - {OverwachPercent:F2}%");
            Console.WriteLine($"Others - {otherPercent:F2}%");
        }
    }
}
