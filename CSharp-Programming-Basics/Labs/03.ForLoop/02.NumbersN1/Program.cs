using System;

namespace _02.NumbersN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i=i-1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
