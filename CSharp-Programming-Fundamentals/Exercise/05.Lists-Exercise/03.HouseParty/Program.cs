using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>(n);
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                List<string> comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[2]=="going!")
                {
                    if (guestList.Contains(comand[0]))
                    {
                        Console.WriteLine($"{comand[0]} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(comand[0]);
                    }
                }
                else 
                {
                    if (guestList.Contains(comand[0]))
                    {
                        guestList.Remove(comand[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comand[0]} is not in the list!");
                    }
                }
                
            }
            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
