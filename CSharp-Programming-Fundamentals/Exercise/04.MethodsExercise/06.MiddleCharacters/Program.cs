using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetMiddleCharacter(word);
        }

        private static void GetMiddleCharacter(string word)
        {
            string chars = string.Empty;
            if (word.Length%2==0)
            {
                for (int i = (word.Length / 2) - 1; i <= (word.Length / 2); i++)
                {
                    chars += word[i].ToString();
                }
                
            }
            else
            {
                for (int i = word.Length / 2; i < (word.Length / 2) + 1; i++)
                {
                    chars = word[i].ToString();
                }
            }
            Console.WriteLine(chars);
        }
    }
}
