﻿using System;

namespace _05.specialNumbers
{
    class specialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                while (num!=0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                if (sum==5)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else if (sum==7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else if (sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
