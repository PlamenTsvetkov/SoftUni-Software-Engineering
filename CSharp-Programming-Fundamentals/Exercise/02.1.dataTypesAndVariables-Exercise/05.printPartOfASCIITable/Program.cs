using System;

namespace _05.printPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte startNum = byte.Parse(Console.ReadLine());
            byte finalNum = byte.Parse(Console.ReadLine());

            for (int i = startNum; i <= finalNum; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}
