using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .ToList();
            double average = theList.Average();
            List<int> result = new List<int>();
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i]>average)
                {
                    result.Add(theList[i]);
                }
                if (result.Count==5)
                {
                    break;
                }
            }         
            if (result.Count==0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ",result));
            }
        }
    }
}
