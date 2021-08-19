using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Craft!")
                {
                    break;
                }
                List<string> allCommand = input
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                string command = allCommand[0];
                if (command == "Collect")
                {
                    string currentItem = allCommand[1];

                    if (collection.Contains(currentItem))
                    {
                        continue;
                    }
                    else
                    {
                        collection.Add(currentItem);
                    }
                }
                else if (command == "Drop")
                {
                    string currentItem = allCommand[1];

                    if (collection.Contains(currentItem))
                    {
                        collection.Remove(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] items = allCommand[1]
                        .Split(":", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (collection.Contains(oldItem))
                    {
                        int indexOf = collection.IndexOf(oldItem);
                        if (indexOf == collection.Count - 1)
                        {
                            collection.Add(newItem);
                        }
                        else
                        {
                            collection.Insert(indexOf+1, newItem);
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Renew")
                {
                    string currentItem = allCommand[1];

                    if (collection.Contains(currentItem))
                    {
                        collection.Remove(currentItem);
                        collection.Add(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
