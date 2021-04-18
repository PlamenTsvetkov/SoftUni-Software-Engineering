using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double high = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double totalWall = Math.Ceiling((high * width*4) - ((high * width*4) * percent / 100));
            string input = Console.ReadLine(); 
            while ( input !="Tired!")
            {
                int paint = int.Parse(input);
                totalWall -= paint;
                if (totalWall<=0)
                {
                    break;
                }
                input =Console.ReadLine();
            }
            if (totalWall==0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
            else if (totalWall<0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(totalWall)} l paint left!");
            }
            else
            {
                Console.WriteLine($"{totalWall} quadratic m left.");
            }
        }
    }
}
