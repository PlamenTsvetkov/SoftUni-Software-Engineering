﻿using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    evenSum += array[i];
                }
                else
                {
                    oddSum += array[i];
                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
