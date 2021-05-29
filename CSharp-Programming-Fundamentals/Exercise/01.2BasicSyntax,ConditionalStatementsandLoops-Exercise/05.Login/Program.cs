using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                char letter = username[i];
                password += letter;
            }
            string input = Console.ReadLine();
            int incorect = 0;
            while (input !=password)
            {
                if (input!=password)
                {
                    incorect++;
                    if (incorect==4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                input =Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
