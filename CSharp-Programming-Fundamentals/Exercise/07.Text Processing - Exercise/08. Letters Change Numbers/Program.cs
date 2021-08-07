using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            decimal totalSum = 0;
            

            for (int i = 0; i < line.Count; i++)
            {
                string currentString = line[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                decimal currentNum = decimal.Parse(currentString.Substring(1, currentString.Length - 2));
                decimal firstSecondNum = 0;
                decimal secondtSecondNum = 0;
                decimal currentSum = 0;
                if (char.IsUpper(firstLetter))
                {
                     
                    firstSecondNum = firstLetter - 64;
                    currentSum = currentNum / firstSecondNum;

                }
                else
                {
                    
                    firstSecondNum = firstLetter - 96;
                    currentSum = currentNum * firstSecondNum;
                }
                if (char.IsUpper(lastLetter))
                {
                    secondtSecondNum = lastLetter - 64;
                    currentSum -= secondtSecondNum;
                }
                else
                {
                    secondtSecondNum = lastLetter - 96;
                    currentSum += secondtSecondNum;
                }
                totalSum += currentSum;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
