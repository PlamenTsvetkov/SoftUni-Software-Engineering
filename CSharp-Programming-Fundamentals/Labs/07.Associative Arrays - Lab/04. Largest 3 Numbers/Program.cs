using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intiger = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            intiger = intiger.OrderByDescending(x => x).ToList();
            for (int i = 0; i < 3; i++)
            {
                if (i<intiger.Count)
                {
                    Console.Write($"{intiger[i]} ");
                }
                else
                {
                    break;
                }
                
            }
            
        }
    }
}
