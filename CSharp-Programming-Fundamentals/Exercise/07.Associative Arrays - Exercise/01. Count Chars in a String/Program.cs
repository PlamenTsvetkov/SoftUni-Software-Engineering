using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (!countChars.ContainsKey(item[i]))
                    {
                        countChars.Add(item[i], 1);
                    }
                    else
                    {
                        countChars[item[i]]++;
                    }
                }
            }
            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
