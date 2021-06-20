﻿using System;
using System.Linq;

namespace _06.equalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                                   
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumRight += arr[k];

                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
