using System;

namespace _06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {            
            int bestPoint = 0;
            string winner = "";
            string name = Console.ReadLine();

            while (name!="Stop")
            {
               
                int currentPoint = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == name[i])
                    {
                        currentPoint += 10;
                    }
                    else
                    {
                        currentPoint += 2;
                    }                   
                }
                if (currentPoint >= bestPoint)
                {
                    bestPoint = currentPoint;
                    winner = name;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winner} with {bestPoint} points!");
        }
    }
}
