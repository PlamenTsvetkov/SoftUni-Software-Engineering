using System;

namespace _06.AnaCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            
            string sumCakeString = Console.ReadLine();
            int totalSumCake = 0;
            int totalCake = width * lenght;
            while (sumCakeString != "STOP")
            {
                int sumCake = int.Parse(sumCakeString);
                totalSumCake += sumCake;
                if (totalSumCake >= totalCake)
                {
                    break;
                }
                sumCakeString = Console.ReadLine();
            }
            int cakeLeft = totalCake - totalSumCake;
            int moreCake = totalSumCake - totalCake;
            if (sumCakeString == "STOP")
            {
                Console.WriteLine($"{cakeLeft} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {moreCake} pieces more.");
            }

            
        }
    }
}
