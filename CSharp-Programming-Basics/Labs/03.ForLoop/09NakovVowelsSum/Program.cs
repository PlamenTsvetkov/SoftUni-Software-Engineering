using System;

namespace _09NakovVowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете дума по избор : ");
            string word = Console.ReadLine();

            int sumLetter = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                switch (letter)
                {
                    case 'a':
                        sumLetter += 1;
                        break;
                    case 'e':
                        sumLetter += 2;
                        break;
                    case 'i':
                        sumLetter += 3;
                        break;
                    case 'o':
                        sumLetter += 4;
                        break;
                    case 'u':
                        sumLetter += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sumLetter);
        }
    }
}
