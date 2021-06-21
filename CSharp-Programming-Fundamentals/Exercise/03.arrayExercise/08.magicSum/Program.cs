using System;
using System.Linq;

namespace _08.magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (n == arr[i]+arr[j])
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }

        }
    }
}
