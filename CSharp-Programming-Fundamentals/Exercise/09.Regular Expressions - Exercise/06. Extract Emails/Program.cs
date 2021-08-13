using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s)(?<user>[A-Za-z\d]+([\.,-][A-Za-z\d]+)*)@(?<host>[A-Za-z]+([\.-][A-Za-z]+)*\.[a-z]{2,}\b)";
            var regex = Regex.Matches(text, pattern);
            foreach (Match match in regex)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
