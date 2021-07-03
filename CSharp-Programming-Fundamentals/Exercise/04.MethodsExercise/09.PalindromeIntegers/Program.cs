using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                IsPalindrome(input);

            }

            static void IsPalindrome(string input)
            {
                if (input.Length % 2 == 0)
                {
                    string firsPart = string.Empty;
                    string secondPart = string.Empty;
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        firsPart += input[i];
                    }
                    for (int j = input.Length; j >= (input.Length / 2) + 1; j--)
                    {
                        secondPart += input[j - 1];
                    }
                    if (firsPart == secondPart)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    string firsPart2 = string.Empty;
                    string secondPart2 = string.Empty;
                    for (int i = 0; i < input.Length / 2; i++)
                    {
                        firsPart2 += input[i];
                    }
                    for (int j = input.Length; j > (input.Length / 2) + 1; j--)
                    {
                        secondPart2 += input[j - 1];
                    }
                    if (firsPart2 == secondPart2)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
        }
    }
}