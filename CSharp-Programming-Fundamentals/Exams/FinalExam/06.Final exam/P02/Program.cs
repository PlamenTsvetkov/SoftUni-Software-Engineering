using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(.+)>(?<p1>[\d]{3})\|(?<p2>[a-z]{3})\|(?<p3>[A-Z]{3})\|(?<p4>[^<>]{3})<\1";
            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                var isTrue = Regex.Match(password, pattern);
                if (isTrue.Success)
                {
                    Console.WriteLine($"Password: {isTrue.Groups["p1"].Value}{isTrue.Groups["p2"].Value}{isTrue.Groups["p3"].Value}{isTrue.Groups["p4"].Value}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }
            }
        }
    }
}
