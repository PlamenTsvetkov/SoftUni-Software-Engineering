using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double eggs = double.Parse(Console.ReadLine());
            string action = "";
            int quantityEggs = 0;
            int soldEggs = 0;
            while ((action = Console.ReadLine()) != "Close")
            {
                quantityEggs = int.Parse(Console.ReadLine());
                if (action=="Buy")
                {
                    if (eggs >= quantityEggs)
                    {
                        eggs -= quantityEggs;
                        soldEggs += quantityEggs;
                    }
                    else if (eggs<quantityEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggs}.");
                        break;
                    }
                }
                else if (action=="Fill")
                {
                    eggs += quantityEggs;
                }
            }
            if (action=="Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
