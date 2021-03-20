using System;

namespace _03AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake" || animal == "reptile")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
