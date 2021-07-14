using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> massivList = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToList();
            for (int i = 0; i < massivList.Count; i++)
            {
                List<string> newList = massivList[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int j = 0; j < newList.Count; j++)
                {
                    Console.Write($"{newList[j]} ");
                }
            }
            
        }
    }
}
