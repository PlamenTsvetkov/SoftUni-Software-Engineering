using System;

namespace _09.AnaMoving
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            string num = Console.ReadLine();

            double  totalBox = 0.00;

            double cubik = width * lenght * height;

            while (num != "Done")
            {
                int box = int.Parse(num);
                totalBox += box;
                if (cubik <= totalBox)
                {
                    Console.WriteLine($"No more free space! You need {totalBox-cubik} Cubic meters more.");
                    break;
                }
                num = Console.ReadLine(); 
            }
            if (cubik > totalBox)
            {
                Console.WriteLine($"{cubik-totalBox} Cubic meters left.");
            }
        }
    }
}
