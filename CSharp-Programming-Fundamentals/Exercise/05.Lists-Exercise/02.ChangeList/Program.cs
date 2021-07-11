using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[0]=="Delete")
                {
                    while (lists.Remove(int.Parse(comand[1])))
                    {
                        lists.Remove(int.Parse(comand[1]));
                    }
                }
                else if (comand[0] == "Insert")
                {
                    lists.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
            }
            Console.WriteLine(string.Join(" ", lists));
        }
    }
}
