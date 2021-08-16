using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int winCounter = 0;
            while ((input = Console.ReadLine())!="End of battle")
            {
                int distance = int.Parse(input);
                if (health>=distance)
                {
                    winCounter++;
                    health -= distance;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCounter} won battles and {health} energy");
                    return;
                }
                if (winCounter%3==0)
                {
                    health += winCounter;
                }

            }
            Console.WriteLine($"Won battles: {winCounter}. Energy left: {health}");
        }
    }
}
