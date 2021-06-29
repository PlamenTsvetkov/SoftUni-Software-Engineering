using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int vowelsNum = CountCowels(word);
            Console.WriteLine(vowelsNum);
        }

        private static int CountCowels(string word)
        {
            int vowelsCount = 0;
            for (int i = 0; i < word.Length; i++) 
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelsCount++;
                        break;
                    default:
                        break;
                }
            }
            return vowelsCount;
        }
    }
}
