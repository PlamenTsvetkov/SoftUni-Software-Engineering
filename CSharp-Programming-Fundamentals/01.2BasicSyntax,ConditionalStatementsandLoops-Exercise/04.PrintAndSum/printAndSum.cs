using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int sumNum = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                Console.Write($"{i} ");
                sumNum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumNum}");
        }
    }
}
