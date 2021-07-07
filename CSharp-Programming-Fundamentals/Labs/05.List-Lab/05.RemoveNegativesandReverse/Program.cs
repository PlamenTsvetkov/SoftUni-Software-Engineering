using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            List<int> result = list1
                .Where(n => n >= 0)
                .Reverse()
                .ToList();
            if (result.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
