using System;
using System.Linq;

namespace _05.topIntegers
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
                bool isTrue = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]>=arr[i])
                    {
                        isTrue = false;
                    }
                }
                if (isTrue)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
