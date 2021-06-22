using System;
using System.Linq;

namespace _09.kaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
           
            
            int bestCounter = 0;
            int index = 0;
            int minIndex = 0;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            
            int[] bestArr = new int[n];
            int inputCounter = 0;
            int bestMinIndex = 0;
            while (input != "Clone them!")
            {
                int[] arr = input
                           .Split(new char[] {'!'}, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
                inputCounter++;
                int currentSum = 0;
                int maxCounter = 1;
                int counter = 1;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i]==arr[i-1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                        index = i;
                    }
                    if (counter>maxCounter)
                    {
                        maxCounter = counter;
                        minIndex = index;
                    }
                    currentSum += arr[i];

                }
                currentSum += arr[0];
                if (maxCounter>bestCounter)
                {
                    bestSequenceIndex = inputCounter;
                    bestSequenceSum = currentSum;
                    bestArr = arr.ToArray();
                    bestMinIndex = minIndex;
                    bestSequenceSum = currentSum;
                    bestCounter = maxCounter;
                }
                else if (maxCounter==bestCounter)
                {
                    if (minIndex<bestMinIndex)
                    {
                        bestSequenceIndex = inputCounter;
                        bestSequenceSum = currentSum;
                        bestArr = arr.ToArray();
                        bestMinIndex = minIndex;
                        bestSequenceSum = currentSum;
                        bestCounter = maxCounter;
                    }
                    else if (minIndex == bestMinIndex)
                    {
                        if (currentSum > bestSequenceSum)
                        {
                            bestSequenceIndex = inputCounter;
                            bestSequenceSum = currentSum;
                            bestArr = arr.ToArray();
                            bestMinIndex = minIndex;
                            bestSequenceSum = currentSum;
                            bestCounter = maxCounter;
                        }
                        
                    }
                }
               
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            for (int i = 0; i < bestArr.Length; i++)
            {
                Console.Write($"{bestArr[i]} ");
            }
        }
    }
}
