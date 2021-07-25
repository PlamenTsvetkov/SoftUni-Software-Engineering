using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence= Console.ReadLine().ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> oddWord = new Dictionary<string, int>();

            foreach (var word in sequence)
            {
                if (oddWord.ContainsKey(word))
                {
                    oddWord[word]++;
                }
                else
                {
                    oddWord.Add(word, 1);
                }
            }
            foreach (var pair in oddWord)
            {
                if (pair.Value%2==1)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
