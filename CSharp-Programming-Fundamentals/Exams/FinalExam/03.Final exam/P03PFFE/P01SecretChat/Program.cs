using System;

namespace P01SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string chat = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Reveal")
                {
                    break;
                }
                string[] allCommand = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                if (command=="InsertSpace")
                {
                    int index = int.Parse(allCommand[1]);
                    chat = chat.Insert(index, " ");
                    Console.WriteLine(chat);
                }
                else if (command == "Reverse")
                {
                    string substring = allCommand[1];
                    if (chat.Contains(substring))
                    {
                        int index = chat.IndexOf(substring);
                        int lenght = substring.Length;
                        chat = chat.Remove(index,lenght);
                        substring = ReverseString(substring);
                        chat = chat + substring;
                        Console.WriteLine(chat);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (command == "ChangeAll")
                {
                    string substring = allCommand[1];
                    string replacement = allCommand[2];
                    while (chat.Contains(substring))
                    {
                        chat = chat.Replace(substring, replacement);
                    }
                    Console.WriteLine(chat);
                }
            }
            Console.WriteLine($"You have a new text message: {chat}");
        }

        public static string ReverseString(string substring)
        {
            char[] array = substring.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
