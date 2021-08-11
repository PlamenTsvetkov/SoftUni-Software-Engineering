using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = string.Empty;
            Dictionary<string, int> contesters = new Dictionary<string, int>();
            while ((input=Console.ReadLine())!="end of race")
            {
                string namePatern = @"[A-Za-z]";
                string kmPatern = @"[0-9]";
                var nameRegex = Regex.Matches(input, namePatern);
                var kmRegex = Regex.Matches(input, kmPatern);
                string nameContester=String.Concat(nameRegex);
                int km = kmRegex.Select(x => int.Parse(x.Value)).Sum();
                if (participants.Contains(nameContester))
                {
                    if (!contesters.ContainsKey(nameContester))
                    {
                        contesters.Add(nameContester, km);
                    }
                    else
                    {
                        contesters[nameContester] += km;
                    }
                }

            }
            List<string> finalResult = contesters.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();
            Console.WriteLine($"1st place: {finalResult[0]}");
            Console.WriteLine($"2nd place: {finalResult[1]}");
            Console.WriteLine($"3rd place: {finalResult[2]}");
            



        }
    }
}
