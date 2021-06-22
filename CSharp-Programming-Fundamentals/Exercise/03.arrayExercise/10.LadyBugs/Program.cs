using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexex = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < initialIndexex.Length; i++)
            {
                int currentIndex = initialIndexex[i];
                if (currentIndex>=0 && currentIndex<fieldSize)
                {
                    field[currentIndex] = 1;
                }

            }
            string comand = string.Empty;
            while ((comand =Console.ReadLine())!="End")
            {
                string[] element = comand.Split();
                int ladybugIndex = (int.Parse)(element[0]);
                string direction = element[1];
                int flyLenght = int.Parse(element[2]);
                if (ladybugIndex < 0 || ladybugIndex > field.Length-1 || field[ladybugIndex] == 0);
                {
                    continue;
                }
                field[ladybugIndex] = 0;
                if (direction=="right")
                {
                    
                }
                else if (direction=="left")
                {

                }
            }
        }
    }
}
