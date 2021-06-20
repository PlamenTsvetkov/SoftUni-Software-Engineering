using System;
using System.Linq;

namespace _07.maxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            string sequence = string.Empty;
            string maxsequence = string.Empty;
            int maxCounter = int.MinValue;
            int counter = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    sequence = arr[i].ToString();
                }
                else
                {
                    counter = 0;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxsequence = sequence;
                }
            }
            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write($"{maxsequence} ");
            }
        }
    }
}
