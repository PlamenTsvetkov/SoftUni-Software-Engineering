using System;
using System.Numerics;

namespace _10.pokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());

            double originalN = n;
            int target = 0;
            while (n>=m)
            {
                if (n==originalN/2 && y>0)
                {
                    n /= y;

                    if (n < m)
                    {
                        break;
                    }
                }
                n -= m;
                target++;
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
