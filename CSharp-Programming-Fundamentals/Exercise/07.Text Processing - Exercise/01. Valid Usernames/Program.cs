using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> validUserNames = new List<string>();
            for (int i = 0; i < userNames.Count; i++)
            {
                if (userNames[i].Length>=3 && userNames[i].Length<=16)
                {
                    bool isValid = true;
                    for (int j = 0; j < userNames[i].Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(userNames[i][j])|| userNames[i][j]=='-' || userNames[i][j] == '_'))
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        validUserNames.Add(userNames[i]);
                    }
                }
               
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }
    }
}
