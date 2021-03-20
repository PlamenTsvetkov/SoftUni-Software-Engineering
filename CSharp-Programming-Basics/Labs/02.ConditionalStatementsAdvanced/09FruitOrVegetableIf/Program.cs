using System;

namespace _09FruitOrVegetableIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();

            if (product =="banana")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato")
            {
                Console.WriteLine("vegetable");
            }
            else if (product == "cucumber")
            {
                Console.WriteLine("vegetable");
            }
            else if (product == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else if (product == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else 
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
