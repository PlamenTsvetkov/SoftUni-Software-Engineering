using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i <n; i++)
            {
                string newKey = Console.ReadLine();
                string newValue =Console.ReadLine();
                if (!dictionary.ContainsKey(newKey))
                {
                    dictionary.Add(newKey, new List<string> { newValue });
                }
                else
                {
                    dictionary[newKey].Add(newValue);
                }
            }
            foreach (var pair in dictionary)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{pair.Key} - {string.Join(", ", pair.Value)}").ToString();
                Console.WriteLine(sb);
            }
        }
    }
}
