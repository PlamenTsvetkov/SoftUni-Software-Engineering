using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\/=])(?<destination>[A-Z][a-zA-Z]{2,})\1";
            var regex = Regex.Matches(text, pattern);
            int points = 0;
            List<string> destination = new List<string>();
            foreach (Match match in regex)
            {
                points += match.Groups["destination"].Value.Length;
                destination.Add(match.Groups["destination"].Value);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
