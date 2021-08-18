using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Go Shopping!")
                {
                    break;
                }
                List<string> allCommand = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                string command = allCommand[0];
                if (command == "Urgent")
                {
                    string currentItem = allCommand[1];
                    if (shoppingList.Contains(currentItem))
                    {
                        continue;
                    }
                    else
                    {
                        shoppingList.Insert(0, currentItem);
                    }

                }
                else if (command == "Unnecessary")
                {
                    string currentItem = allCommand[1];
                    if (shoppingList.Contains(currentItem))
                    {
                        shoppingList.Remove(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Correct")
                {
                    string oldItem = allCommand[1];
                    string newItem = allCommand[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        int oldItemIndex = shoppingList.IndexOf(oldItem);
                        shoppingList.RemoveAt(oldItemIndex);
                        shoppingList.Insert(oldItemIndex, newItem);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Rearrange")
                {
                    string currentItem = allCommand[1];
                    if (shoppingList.Contains(currentItem))
                    {
                        shoppingList.Remove(currentItem);
                        shoppingList.Add(currentItem);
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            Console.WriteLine(string.Join(", ",shoppingList));
        }
    }
}
