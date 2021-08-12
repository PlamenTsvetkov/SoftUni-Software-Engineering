using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> demonNames = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, List<double>> demons = new Dictionary<string, List<double>>();
            string patternHealth = @"[^\d+*\/.-]";
            string patternDMG = @"[-+]?([0-9]*\.[0-9]+|[0-9]+)";
            string patternComand = @"[\*\/]";
            for (int i = 0; i < demonNames.Count; i++)
            {
                var regexHealth = Regex.Matches(demonNames[i], patternHealth);
                double totalHealth = 0;
                foreach (Match match in regexHealth)
                {
                    totalHealth += char.Parse(match.Value);
                }
                var regexDMG = Regex.Matches(demonNames[i], patternDMG);
                double totalDmg = 0;
                foreach (Match match in regexDMG)
                {
                    totalDmg += double.Parse(match.Value);
                }
                var regexComand = Regex.Matches(demonNames[i], patternComand);
                foreach (Match match in regexComand)
                {
                    if (match.Value == "*")
                    {
                        totalDmg *= 2;
                    }
                    else
                    {
                        totalDmg /= 2;
                    }
                }
                demons.Add(demonNames[i], new List<double> { totalHealth, totalDmg });
            }
            foreach (var item in demons.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }

        }
    }
}
