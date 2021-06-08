using System;

namespace _04.sumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int intLetter = 0;
            int sumLetter = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                intLetter = (int)letter;
                sumLetter += intLetter;
            }
            Console.WriteLine($"The sum equals: {sumLetter}");
        }
    }
}
