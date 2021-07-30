using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();
            List<string> forceUsers = new List<string>();
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                List<string> dataInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (dataInput[1] == "|")
                {
                    List<string> realInput = input
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                    string currentTeam = realInput[0];
                    string currentUser = realInput[1];

                    if (!forceUsers.Contains(currentUser))
                    {
                        forceUsers.Add(currentUser);
                        if (!teams.ContainsKey(currentTeam))
                        {
                            teams.Add(currentTeam, new List<string> { currentUser });
                        }
                        else
                        {
                            teams[currentTeam].Add(currentUser);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    List<string> realInput = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    string currentUser = realInput[0];
                    string currentTeam = realInput[1];
                    if (!forceUsers.Contains(currentUser))
                    {
                        forceUsers.Add(currentUser);
                        if (!teams.ContainsKey(currentTeam))
                        {
                            teams.Add(currentTeam, new List<string> { currentUser });
                        }
                        else
                        {
                            teams[currentTeam].Add(currentUser);
                        }

                    }
                    else
                    {
                        string userCurentSide = string.Empty;
                        foreach (var key in teams.Keys)
                        {
                            if (teams[key].Contains(currentUser))
                            {
                                userCurentSide = key;
                                break;
                            }
                        }
                        teams[userCurentSide].Remove(currentUser);
                        if (!teams.ContainsKey(currentTeam))
                        {
                            teams.Add(currentTeam, new List<string> { currentUser });
                        }
                        else
                        {
                            teams[currentTeam].Add(currentUser);
                        }
                    }
                    Console.WriteLine($"{currentUser} joins the {currentTeam} side!");
                    if (!forceUsers.Contains(currentUser))
                    {
                        forceUsers.Add(currentUser);
                    }
                }
            }
            foreach (var pair in teams.OrderByDescending(pair=>pair.Value.Count).ThenBy(pair=>pair.Key))
            {
                if (pair.Value.Count>0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                    foreach (var user in pair.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"! {user}" );
                    }
                }
            }
        }
    }
}
