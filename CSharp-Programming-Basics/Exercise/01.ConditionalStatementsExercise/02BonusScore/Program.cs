using System;
using System.Threading;
using System.Xml;

namespace _02BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonus = 0.00;

            if (points >1000)
            {
                bonus = points * 0.1;
            }
            else if (points <= 100)
            {
                bonus = 5;
            }
            else
            {
                bonus = points * 0.2;
            }
            if (points % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (points % 5 == 0)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + points);
        }
    }
}
