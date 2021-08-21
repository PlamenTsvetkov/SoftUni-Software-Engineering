using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string worldTour = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(worldTour);
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Travel")
            {
                List<string> command = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string stringInput = command[2];
                    if (sb.Length >= index && index>=0)
                    {
                        sb.Insert(index, stringInput);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine(sb.ToString());
                        continue;
                    }
                }
                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIntex = int.Parse(command[2]);
                    int removeLenght = endIntex - startIndex + 1;
                    if ((sb.Length >= startIndex && startIndex>=0) && (sb.Length >= endIntex && endIntex>=0))
                    {
                        sb.Remove(startIndex, removeLenght);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine(sb.ToString());
                        continue;
                    }
                }
                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];
                    worldTour = sb.ToString();
                    if (worldTour.IndexOf(oldString)>0)
                    {
                        while(worldTour.IndexOf(oldString) > 0)
                        {
                            sb.Replace(oldString, newString);
                            Console.WriteLine(sb.ToString());
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine(sb.ToString());
                        continue;
                    }
                    
                }
            }
            worldTour = sb.ToString();
            Console.WriteLine($"Ready for world tour! Planned stops: {worldTour}");
        }
    }
}
