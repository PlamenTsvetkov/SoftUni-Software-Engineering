using System;

namespace _05NakovMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете N на брой числа :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Напиши максимална сума :");
            int maxNum = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("num {0} =", i);
                int num = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine("Max =" + maxNum);
        }
    }
}
