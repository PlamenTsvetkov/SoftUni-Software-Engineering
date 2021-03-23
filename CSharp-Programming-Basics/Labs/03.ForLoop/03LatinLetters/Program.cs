using System;

namespace _03LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Азбуката е :");
            for (var letter = 'a'; letter <= 'z'; letter++)
            {

                Console.Write(" " + letter);
            }
        }
    }
}
