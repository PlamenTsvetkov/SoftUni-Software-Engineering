using System;

namespace _05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActior = Console.ReadLine();
         double point = double.Parse(Console.ReadLine());
         double pointer = double.Parse(Console.ReadLine());
            for (int i = 0; i < pointer; i++)
            {
                double currentPoint = 0;
                string namePointer = Console.ReadLine();
               double pointPointer = double.Parse(Console.ReadLine());
                currentPoint = namePointer.Length * pointPointer / 2;
                point += currentPoint;
                if (point>1250.50)
                {
                    Console.WriteLine($"Congratulations, {nameActior} got a nominee for leading role with {point:f1}!");
                    break;
                }
                
            }
            if (point<1250.50)
            {
                Console.WriteLine($"Sorry, {nameActior} you need {1250.50-point:f1} more!");
            }
        }
    }
}
