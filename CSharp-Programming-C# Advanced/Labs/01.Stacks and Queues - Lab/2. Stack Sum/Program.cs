using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var myStack = new Stack<int>(list);
            string input = string.Empty;
            while ((input = Console.ReadLine().ToLower())!="end")
            {
                List<string> allCommand = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = allCommand[0];
                if (command=="add")
                {
                    int number1 = int.Parse(allCommand[1]);
                    int number2 = int.Parse(allCommand[2]);
                    myStack.Push(number1);
                    myStack.Push(number2);
                }
                else if (command == "remove")
                {
                    int index = int.Parse(allCommand[1]);
                    if (myStack.Count>= index)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            myStack.Pop();
                        }
                    }
                    
                }

            }
            Console.WriteLine($"Sum: {myStack.Sum()}");
        }
    }
}
