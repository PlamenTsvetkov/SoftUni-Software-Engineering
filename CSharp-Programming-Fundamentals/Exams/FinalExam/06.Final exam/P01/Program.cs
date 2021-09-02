using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sign up")
                {
                    break;
                }
                string[] allCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                if (command=="Case")
                {
                    string type = allCommand[1];
                    if (type=="lower")
                    {
                        username = username.ToLower();
                    }
                    else
                    {
                        username = username.ToUpper();
                    }
                    Console.WriteLine(username);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(allCommand[1]);
                    int endIndex = int.Parse(allCommand[2]);
                    int lenght = endIndex - startIndex + 1;
                    if (startIndex>=0 && startIndex<username.Length
                        && endIndex>=0 && endIndex < username.Length)
                    {
                        string substring = username.Substring(startIndex, lenght);
                        string reverseString = ReverseString(substring);
                        Console.WriteLine(reverseString);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Cut")
                {
                    string substring =allCommand[1];
                    
                    if (username.Contains(substring))
                    {
                        int startIndex = username.IndexOf(substring);
                        int lenght = substring.Length;
                        username = username.Remove(startIndex, lenght);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    char currentChar = char.Parse(allCommand[1]);

                    while (username.Contains(currentChar))
                    {
                        username = username.Replace(currentChar,'*');
                    }
                    Console.WriteLine(username);
                }
                else if (command == "Check")
                {
                    char currentChar = char.Parse(allCommand[1]);

                    if (username.Contains(currentChar))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {currentChar}.");
                    }
                }
            }
            }

        public static string ReverseString(string substring)
        {
            char[] array = substring.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
