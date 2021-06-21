using System;
using System.Linq;

namespace _07.maxSequenceOfEqualElements2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
            int startIterate = 0;
            int maxCounter = 1;
            int counter = 1;
            int maxStartI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                    startIterate = i;
                }
                if (counter>maxCounter)
                {
                    maxCounter = counter;
                    maxStartI = startIterate;
                }
            }
            for (int i = maxStartI; i < maxStartI+maxCounter; i++)
            {
                Console.Write($"{arr[i]} ");              
            }
        }
    }
}
