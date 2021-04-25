using System;

namespace _05.FitnesCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = double.Parse(Console.ReadLine());
          double back = 0;
          double chest = 0;
          double legs = 0;
          double abs = 0;
          double proteinShake = 0;
          double proteinBar = 0;
            double train = 0;
            double forProtein = 0;
            for (int i = 0; i < quantity; i++)
            {
                string type = Console.ReadLine().ToLower();
                if (type=="back")
                {
                    back += 1;
                    train += 1;
                }
                else if (type == "chest")
                {
                    chest += 1;
                    train += 1;
                }
                else if (type == "legs")
                {
                    legs += 1;
                    train += 1;
                }
                else if (type == "abs")
                {
                    abs += 1;
                    train += 1;
                }
                else if (type == "protein shake")
                {
                    proteinShake += 1;
                    forProtein += 1;
                }
                else if (type == "protein bar")
                {
                    proteinBar += 1;
                    forProtein += 1;
                }
            }
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{train/quantity*100:F2}% - work out");
            Console.WriteLine($"{forProtein / quantity * 100:F2}% - protein");
        }
    }
}
