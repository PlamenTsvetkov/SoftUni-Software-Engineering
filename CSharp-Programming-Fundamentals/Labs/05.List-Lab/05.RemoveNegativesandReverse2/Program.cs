using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesandReverse2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i]<0)
                {
                    list1.RemoveAt(i);
                    i--;
                }
                
            }
            list1.Reverse();
            if (list1.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list1));
            }
           
        }
    }
}
