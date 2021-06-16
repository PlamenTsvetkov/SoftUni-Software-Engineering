using System;

namespace _01.train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                train[i] =int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < train.Length; i++)
            {
                total += train[i];
            }
            Console.WriteLine(string.Join(' ',train));
            Console.WriteLine(total);
        }
    }
}
