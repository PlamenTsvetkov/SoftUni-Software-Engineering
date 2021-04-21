using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double sneakers = tax * 0.60;
            double outfit = sneakers * 0.80;
            double ball = outfit / 4;
            double other = ball / 5;
            double total = tax + sneakers + outfit + ball + other;
            Console.WriteLine($"{total:f2}");
        }
    }
}
