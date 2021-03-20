using System;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.CompilerServices;

namespace _06AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:F3}", a * a );
            }
            else if (shape == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", b * c ) ;
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Math.PI * r * r );
            }
            else if (shape == "triangle")
            {
                double d = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", d * e / 2 );
            }
        }
    }
}
