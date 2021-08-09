using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //MatchCollection dates = Regex.Matches(Console.ReadLine(), @"\b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");
            var pattern = @"\b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string datesString =Console.ReadLine();

            
            var dates = Regex.Matches(datesString,pattern);
            Console.WriteLine(dates.Count);
            foreach (Match match in dates)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[2].Value}, Year: {match.Groups[3].Value}");
            }
        }
    }
}

