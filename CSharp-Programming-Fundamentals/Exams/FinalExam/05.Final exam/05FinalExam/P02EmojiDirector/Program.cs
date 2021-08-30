using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02EmojiDirector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patternText = @"([:|\*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternDigits = @"\d";
            var regexDigits = Regex.Matches(text, patternDigits);
            int coolTreshold = 1;
            foreach (Match match in regexDigits)
            {
                coolTreshold *= int.Parse(match.Value);
            }
            var regexEmojis = Regex.Matches(text, patternText);
            List<string> coolEmojis = new List<string>();
            foreach (Match match in regexEmojis)
            {
                string currentEmoji = match.Groups["emoji"].Value;
                int currentEmojiPoint = 0;
                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    currentEmojiPoint += currentEmoji[i];
                }
                if (currentEmojiPoint>=coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{regexEmojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine,coolEmojis));
        }
    }
}
