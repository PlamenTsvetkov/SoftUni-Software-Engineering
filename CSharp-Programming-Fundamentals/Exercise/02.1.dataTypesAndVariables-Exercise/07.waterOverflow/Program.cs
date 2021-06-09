using System;

namespace _07.waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLiter = 0;
            
            for (int i = 0; i < n; i++)
            {
                int liter = int.Parse(Console.ReadLine());
                byte capacity = 255;
                if (totalLiter+liter>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                totalLiter += liter;
            }
            Console.WriteLine(totalLiter);
        }
    }
}
