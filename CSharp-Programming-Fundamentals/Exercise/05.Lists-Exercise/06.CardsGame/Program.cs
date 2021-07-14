using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHands = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();
            List<int> secondHands = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();
            int cardsInHand = firstHands.Count;
            while (firstHands.Count>0 && secondHands.Count>0)            
            {
                if (firstHands[0] > secondHands[0])
                {
                    int firstCard = firstHands[0];
                    for (int j = 0; j < firstHands.Count - 1; j++)
                    {

                        firstHands[j] = firstHands[j + 1];

                    }
                    firstHands[firstHands.Count - 1] = firstCard;
                    firstHands.Add(secondHands[0]);
                    secondHands.RemoveAt(0);
                }
                else if (firstHands[0] < secondHands[0])
                {
                    int firstCard = secondHands[0];
                    for (int j = 0; j < secondHands.Count - 1; j++)
                    {

                        secondHands[j] = secondHands[j + 1];

                    }
                    secondHands[secondHands.Count - 1] = firstCard;
                    secondHands.Add(firstHands[0]);
                    firstHands.RemoveAt(0);
                }
                else
                {
                    firstHands.RemoveAt(0);
                    secondHands.RemoveAt(0);
                }
            }
            if (firstHands.Sum() >0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHands.Sum()}");
            }
            else 
            {
                Console.WriteLine($"Second player wins! Sum: {secondHands.Sum()}");
            }
        }
    }
}
