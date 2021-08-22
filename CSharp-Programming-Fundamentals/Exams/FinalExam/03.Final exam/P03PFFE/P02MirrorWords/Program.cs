using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string textPattern = @"([@|#])(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";
            var regex = Regex.Matches(text, textPattern);
            List<string> mirrorList = new List<string>();
            if (regex.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{regex.Count} word pairs found!");
            }
            foreach (Match match in regex)
            {
                string firstWord = match.Groups["firstWord"].Value;
                string secondWord = match.Groups["secondWord"].Value;
                string reverseSecondWord = ReverseString(secondWord);
                if (firstWord==reverseSecondWord)
                {
                    mirrorList.Add($"{firstWord} <=> {secondWord}");
                }
            }
            if (mirrorList.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",mirrorList));
            }
        }

        public static string ReverseString(string secondWord)
        {
            char[] array = secondWord.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
