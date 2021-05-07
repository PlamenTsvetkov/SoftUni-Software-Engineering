using System;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string isEnd = "";
            int is3 = 0;
            double totalObem = 0;
            int suitcase = 0;
            while ((isEnd = Console.ReadLine())!="End")
            {
                double obem = double.Parse(isEnd);
                is3 += 1;
                if (is3%3==0)
                {
                    obem = obem * 1.1;
                }
                if (capacity-totalObem<obem)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }
                suitcase += 1;
                totalObem += obem;
            }
            if (isEnd=="End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcase} suitcases loaded.");
        }
    }
}
