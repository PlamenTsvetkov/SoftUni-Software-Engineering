using System;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
           double easterBredNum = double.Parse(Console.ReadLine());
           double maxUsedSugar = 0;
           double maxUsedFlour = 0;
           double totalSugar = 0;
           double totalFlour = 0;
            for (int i = 0; i < easterBredNum; i++)
            {
              double sugarGr = 0;
              double flourGr = 0;
                sugarGr = double.Parse(Console.ReadLine());
                flourGr = double.Parse(Console.ReadLine());
                if (maxUsedFlour<flourGr)
                {
                    maxUsedFlour = flourGr;
                }
                if (maxUsedSugar<sugarGr)
                {
                    maxUsedSugar = sugarGr;
                }
                totalFlour += flourGr;
                totalSugar += sugarGr;
            }
            Console.WriteLine($"Sugar: {Math.Ceiling(totalSugar/950)}");
            Console.WriteLine($"Flour: {Math.Ceiling(totalFlour / 750)}");
            Console.WriteLine($"Max used flour is {maxUsedFlour} grams, max used sugar is {maxUsedSugar} grams.");
        }
    }
}
