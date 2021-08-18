using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neightborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int currentPossition = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Love!")
                {
                    break;
                }
                string[] allCommand = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string command = allCommand[0];
                if (command == "Jump")
                {
                    int lenght = int.Parse(allCommand[1]);
                    if (currentPossition + lenght <= neightborhood.Length -1)
                    {
                        currentPossition += lenght;
                        if (neightborhood[currentPossition] == 0)
                        {
                            Console.WriteLine($"Place {currentPossition} already had Valentine's day.");
                        }
                        else
                        {
                            neightborhood[currentPossition] -= 2;
                            if (neightborhood[currentPossition] == 0)
                            {
                                Console.WriteLine($"Place {currentPossition} has Valentine's day.");
                            }
                        }
                    }
                    else
                    {
                        currentPossition = 0;
                        if (neightborhood[currentPossition] == 0)
                        {
                            Console.WriteLine($"Place {currentPossition} already had Valentine's day.");
                        }
                        else
                        {
                            neightborhood[currentPossition] -= 2;
                            if (neightborhood[currentPossition] == 0)
                            {
                                Console.WriteLine($"Place {currentPossition} has Valentine's day.");
                            }
                        }
                    }

                }
            }
            int countHight0 = 0;
            for (int i = 0; i < neightborhood.Length; i++)
            {
                if (neightborhood[i] > 0)
                {
                    countHight0++;
                }
            }
            Console.WriteLine($"Cupid's last position was {currentPossition}.");
            if (countHight0 == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countHight0} places.");
            }
        }
    }
}
