using System;

namespace _03AnaSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int sum = 0;
            while (true)
            {
                int b = int.Parse(Console.ReadLine());
                sum += b;
                if (sum>=a)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
