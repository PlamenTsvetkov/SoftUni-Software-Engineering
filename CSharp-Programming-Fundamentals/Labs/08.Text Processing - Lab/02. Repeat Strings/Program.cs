using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < arrayString.Length; i++)
            {
                for (int k = 0; k < arrayString[i].Length; k++)
                {
                    Console.Write(arrayString[i]);
                }
            }
        }
    }
}
