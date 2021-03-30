using System;

namespace _02AnaPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var pass = Console.ReadLine();
            var input = Console.ReadLine();

            while (input != pass)
            {
                input = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
