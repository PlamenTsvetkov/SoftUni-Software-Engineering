using System;
using System.Linq;

namespace _04.reverseArrayOfStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(' ', arr.Reverse()));
        }
    }
}
