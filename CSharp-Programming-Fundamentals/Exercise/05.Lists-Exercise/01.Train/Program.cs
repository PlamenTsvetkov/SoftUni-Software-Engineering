using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[0]=="Add")
                {
                    wagons.Add(int.Parse(comand[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity-wagons[i]>=int.Parse(comand[0]))
                        {
                            wagons[i] += int.Parse(comand[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
