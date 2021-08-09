using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            MultyplyStringChar(strings[0], strings[1]);
        }

        private static void MultyplyStringChar(string v1, string v2)
        {
            int TotalSum = 0;
            if (v1.Length>v2.Length)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    TotalSum += v1[i] * v2[i];
                }
                for (int i = v2.Length; i < v1.Length; i++)
                {
                    TotalSum += v1[i];
                }
            }
            else if (v1.Length < v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    TotalSum += v1[i] * v2[i];
                }
                for (int i = v1.Length ; i < v2.Length; i++)
                {
                    TotalSum += v2[i];
                }
            }
            else
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    TotalSum += v1[i] * v2[i];
                }
            }
            Console.WriteLine(TotalSum);
        }
    }
}
