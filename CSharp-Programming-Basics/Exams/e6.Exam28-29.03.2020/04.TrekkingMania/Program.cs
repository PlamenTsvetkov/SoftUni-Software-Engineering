using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            double totalPerson = 0;
            double totalMusala = 0;
            double totalMonblan = 0;
            double totalKilimandjaro = 0;
            double totalK2 = 0;
            double totalEverest = 0;
            for (int i = 0; i < group; i++)
            {
                int groupNum = int.Parse(Console.ReadLine());
                totalPerson += groupNum;
                if (groupNum<=5)
                {
                    totalMusala += groupNum;
                }
                else if (5<groupNum && groupNum<=12)
                {
                    totalMonblan += groupNum;
                }
                else if (12 < groupNum && groupNum <= 25)
                {
                    totalKilimandjaro += groupNum;
                }
                else if (25 < groupNum && groupNum <= 40)
                {
                    totalK2 += groupNum;
                }
                else if (40 < groupNum)
                {
                    totalEverest += groupNum;
                }
            }
            Console.WriteLine($"{totalMusala/totalPerson*100:f2}%");
            Console.WriteLine($"{totalMonblan / totalPerson * 100:f2}%");
            Console.WriteLine($"{totalKilimandjaro / totalPerson * 100:f2}%");
            Console.WriteLine($"{totalK2 / totalPerson * 100:f2}%");
            Console.WriteLine($"{totalEverest / totalPerson * 100:f2}%");


        }
    }
}
