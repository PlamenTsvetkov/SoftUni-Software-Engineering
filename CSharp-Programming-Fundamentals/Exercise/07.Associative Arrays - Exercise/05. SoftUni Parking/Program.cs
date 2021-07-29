using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "register")
                {
                    if (users.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                        users.Add(input[1], input[2]);
                    }
                }
                if (input[0] == "unregister")
                {
                    if (!users.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        users.Remove(input[1]);
                    }
                }
            }
            foreach (var pair in users)//•	"{username} => {licensePlateNumber}"
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
