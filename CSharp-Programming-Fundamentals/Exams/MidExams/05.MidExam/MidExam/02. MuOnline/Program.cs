using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int initialHealth = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] allCommand = rooms[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = allCommand[0];
                bestRoom++;
                if (command=="potion")
                {
                    int healthPoint = int.Parse(allCommand[1]);
                    if (initialHealth+healthPoint>100)
                    {
                        int currentHealth = 100 - initialHealth;
                        initialHealth = 100;
                        
                        Console.WriteLine($"You healed for {currentHealth} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        initialHealth += healthPoint;
                        Console.WriteLine($"You healed for {healthPoint} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }


                }
                else if (command == "chest")
                {
                    int bitcoinPoint = int.Parse(allCommand[1]);
                    bitcoins += bitcoinPoint;
                    Console.WriteLine($"You found {bitcoinPoint} bitcoins.");

                }
                else
                {
                    string monster = command;
                    int atackPower = int.Parse(allCommand[1]);
                    initialHealth -= atackPower;
                    if (!(initialHealth<=0))
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
