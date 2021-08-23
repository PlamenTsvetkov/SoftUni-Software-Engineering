using System;
using System.Linq;

namespace P1PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                string[] allCommand = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                if (command=="TakeOdd")
                {
                    string result = string.Empty;
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        result += password[i];
                    }
                    password = result;
                    Console.WriteLine(password);
                }
                else if (command=="Cut")
                {
                    int startIndex = int.Parse(allCommand[1]);
                    int lenth = int.Parse(allCommand[2]);
                    password= password.Remove(startIndex, lenth);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = allCommand[1];
                    string substitute = allCommand[2];
                    if (password.Contains(substring))
                    {
                        while (password.Contains(substring))
                        {

                            password = password.Replace(substring, substitute);
                        }
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
