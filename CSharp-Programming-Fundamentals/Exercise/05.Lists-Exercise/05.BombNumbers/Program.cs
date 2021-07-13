using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();
            List<int> specialNumbers = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();
            for (int i = 0; i < lists.Count; i++)
            {
                int removeBeforeSimvol = 0;
                if (lists[i] == specialNumbers[0])
                {

                    for (int j = 0; j < specialNumbers[1]; j++)
                    {
                        if (i >= specialNumbers[1])
                        {
                            lists.RemoveAt(i - 1);
                            i--;
                        }
                        if (i + 1 <= lists.Count - 1)
                        {
                            lists.RemoveAt(i+ 1);
                        }
                    }
                    lists.RemoveAt(i);
                    i--;

                }
            }
            int sum = 0;
            for (int i = 0; i < lists.Count; i++)
            {
                sum += lists[i];
            }
            Console.WriteLine($"{sum}");
        }
    }
}

