using System;

namespace _08NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value<minValue)
                {
                    minValue = value;
                }
                if (value> maxValue)
                {
                    maxValue = value;
                }
            }
            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}
