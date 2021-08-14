using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int availableSeats = 0;
            int currentSeats = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                 availableSeats += 4 - wagons[i];
                
            }
            for (int i = 0; i < wagons.Length; i++)
            {

                currentSeats = 4 - wagons[i];
                if (waitingPeople> currentSeats)
                {
                    wagons[i] += currentSeats;
                    waitingPeople -= currentSeats;
                    availableSeats -= currentSeats;

                }
                else
                {
                    wagons[i] += waitingPeople;
                    waitingPeople -= waitingPeople;
                    availableSeats -= waitingPeople;
                    break;
                }
                
            }
            if (waitingPeople<1 && availableSeats>0)
            {
                Console.WriteLine($"The lift has empty spots!{Environment.NewLine}{String.Join(" ",wagons)}");
            }
            else if (waitingPeople > 0 && availableSeats < 1)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!{Environment.NewLine}{String.Join(" ", wagons)}");
            }
            else if (waitingPeople == 0 && availableSeats == 1)
            {
                Console.WriteLine($"{String.Join(" ", wagons)}");
            }
        }
    }
}
