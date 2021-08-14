using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = string.Empty;
            int moves = 0;
            while ((input = Console.ReadLine())!= "end")
            {
                moves += 1;
                int[] indexes= input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                if (firstIndex==secondIndex || firstIndex>= elements.Count || secondIndex>= elements.Count
                    || firstIndex <0  || secondIndex < 0)
                {
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    elements.Insert(elements.Count / 2, $"-{moves}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements[firstIndex]==elements[secondIndex])
                {
                    if (firstIndex>secondIndex)
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        elements.RemoveAt(firstIndex);
                        elements.RemoveAt(secondIndex);
                    }
                    else
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        elements.RemoveAt(secondIndex);
                        elements.RemoveAt(firstIndex);
                    }

                }
                else if (elements[firstIndex] != elements[secondIndex])
                {
                    Console.WriteLine("Try again!");

                }
                if (elements.Count==0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }
            Console.WriteLine($"Sorry you lose :(");
              Console.WriteLine(string.Join(" ",elements));
        }
    }
}
