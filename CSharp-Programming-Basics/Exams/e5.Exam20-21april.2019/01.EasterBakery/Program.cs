using System;

namespace _01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double branoPrice = double.Parse(Console.ReadLine());
            double branoKg= double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double quantityEggs = double.Parse(Console.ReadLine());
            double mayaPacket = double.Parse(Console.ReadLine());
            double sugarPrice = branoPrice * 0.75;
            double eggsPrice = branoPrice * 1.1;
            double mayaPrice = sugarPrice * 0.20;
            double totalPrice = branoKg * branoPrice + sugarKg * sugarPrice + quantityEggs * eggsPrice + mayaPacket * mayaPrice;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
