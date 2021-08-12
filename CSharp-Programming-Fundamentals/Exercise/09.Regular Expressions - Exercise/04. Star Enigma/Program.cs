using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> atackPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"[sStTaArR]";
            string patternPlanet = @"([^@!:>-]*)@(?<planetName>[A-Za-z]+)([^@!:>-]*):(?<population>\d*)([^@!:>-]*)!(?<atackType>[AD])!([^@!:>-]*)->(?<soldierCount>\d*)([^@!:>-]*)";
            for (int i = 0; i < n; i++)
            {
                string text =Console.ReadLine();
                var count = Regex.Matches(text, pattern);
                string decryptText = string.Empty;
                foreach (var character in text)
                {
                    decryptText += (char)(character - count.Count);
                }
                var result = Regex.Matches(decryptText, patternPlanet);
                foreach (Match match in result)
                {
                    if (match.Groups["atackType"].Value=="A")
                    {
                        atackPlanets.Add(match.Groups["planetName"].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(match.Groups["planetName"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {atackPlanets.Count}");
            foreach (var item in atackPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
