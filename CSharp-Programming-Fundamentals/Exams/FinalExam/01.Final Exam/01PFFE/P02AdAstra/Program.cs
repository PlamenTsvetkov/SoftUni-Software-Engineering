using System;
using System.Text.RegularExpressions;

namespace P02AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textPattern = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<expirationdate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
            var regex = Regex.Matches(text, textPattern);
            int totalCalories = 0;
            foreach (Match match in regex)
            {
                totalCalories+= int.Parse(match.Groups["calories"].Value);
            }
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in regex)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["expirationdate"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
