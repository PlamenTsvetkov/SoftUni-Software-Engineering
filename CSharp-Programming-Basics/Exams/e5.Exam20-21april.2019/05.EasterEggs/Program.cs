using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            double eggsNum = double.Parse(Console.ReadLine());
            int redColor = 0;
            int orangeColor = 0;
            int blueColor = 0;
            int greenColor = 0;
            
            for (int i = 0; i < eggsNum; i++)
            {
                string eggColor = Console.ReadLine();
                if (eggColor=="red")
                {
                    redColor += 1;
                }
                else if (eggColor == "orange")
                {
                    orangeColor += 1;
                }
                else if (eggColor == "blue")
                {
                    blueColor += 1;
                }
                else if (eggColor == "green")
                {
                    greenColor += 1;
                }
            }
            int maxEggsCount = redColor;
            string maxEggsColor = "red";
            if (maxEggsCount < orangeColor)
            {
                maxEggsCount = orangeColor;
                maxEggsColor = "orange";
            }
            if (maxEggsCount < blueColor)
            {
                maxEggsCount = blueColor;
                maxEggsColor = "blue";
            }
            if (maxEggsCount < greenColor)
            {
                maxEggsCount = greenColor;
                maxEggsColor = "green";
            }
            Console.WriteLine($"Red eggs: {redColor}");
            Console.WriteLine($"Orange eggs: {orangeColor}");
            Console.WriteLine($"Blue eggs: {blueColor}");
            Console.WriteLine($"Green eggs: {greenColor}");
            Console.WriteLine($"Max eggs: {maxEggsCount} -> {maxEggsColor}");
        }
    }
}
