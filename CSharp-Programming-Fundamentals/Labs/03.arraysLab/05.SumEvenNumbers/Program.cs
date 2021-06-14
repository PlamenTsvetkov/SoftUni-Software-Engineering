using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int totalEvenSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    totalEvenSum += arr[i];
                }
            }
            Console.WriteLine(totalEvenSum);
        }
    }
}
