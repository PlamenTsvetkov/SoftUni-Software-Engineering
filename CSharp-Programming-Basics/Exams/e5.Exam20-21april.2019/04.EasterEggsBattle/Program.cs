using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityA = int.Parse(Console.ReadLine());
            int quantityB = int.Parse(Console.ReadLine());
            string result = "";
            while ((result = Console.ReadLine()) != "End of battle")
            {
                if (result=="one")
                {
                    quantityB -= 1;
                }
                else if (result == "two")
                {
                    quantityA -= 1;
                }
                if (quantityA==0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {quantityB} eggs left.");
                    break;
                }
                else if (quantityB==0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {quantityA} eggs left.");
                    break;
                }
            }
            if (result=="End of battle")
            {
                Console.WriteLine($"Player one has {quantityA} eggs left.");
                Console.WriteLine($"Player two has {quantityB} eggs left.");
            }
        }
    }
}
