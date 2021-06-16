using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[array.Length - 1];
            if (array.Length==1)
            {
                Console.WriteLine(array[0]);
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < condensed.Length-i; j++)
                {
                    condensed[j] = array[j] + array[j + 1];

                }
                array= condensed;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}
