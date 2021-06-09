using System;

namespace _06.triplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firsChar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k=0; k < n ; k++)
                    {
                        char thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firsChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
