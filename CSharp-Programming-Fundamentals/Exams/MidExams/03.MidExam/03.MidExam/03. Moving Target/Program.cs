using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                List<string> allCommand = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                string command = allCommand[0];
                if (command=="Shoot")
                {
                    int index = int.Parse(allCommand[1]);
                    int power = int.Parse(allCommand[2]);
                    if (index>=0 && index < targets.Count)
                    {
                        if (targets[index]<= power)
                        {
                            targets.RemoveAt(index);
                        }
                        else
                        {
                            targets[index] -= power;
                        }
                    }
                  
                }
                else if (command == "Add")
                {
                    int index = int.Parse(allCommand[1]);
                    int value = int.Parse(allCommand[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (command == "Strike")
                {
                    int index = int.Parse(allCommand[1]);
                    int radius = int.Parse(allCommand[2]);
                    if (index >= 0 + radius  && index < targets.Count - radius - 1)
                    {
                        targets.RemoveRange(index - radius, (radius * 2) + 1);


                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }

                }

            }
            Console.WriteLine(string.Join("|",targets));
        }
    }
}
