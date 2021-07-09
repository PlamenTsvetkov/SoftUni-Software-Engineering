using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();
            string input = string.Empty;
            while ((input=Console.ReadLine())!="end")
            {
                List <string> comand= input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[0]=="Add")
                {
                    numbers.Add(comand[1]);
                }
                else if (comand[0] == "Remove")
                {
                    numbers.Remove(comand[1]);
                }
                else if (comand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(comand[1]));
                }
                else if (comand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(comand[2]), comand[1]);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
