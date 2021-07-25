using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            for (int i = 0; i < number.Length; i++)
            {
                if (count.ContainsKey(number[i]))
                {
                    count[number[i]]++;
                }
                else
                {
                    count.Add(number[i], 1);
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
