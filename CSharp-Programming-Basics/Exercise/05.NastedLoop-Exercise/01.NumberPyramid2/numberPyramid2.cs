using System;

namespace _01numberPyramid2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxColumn = 0;
            bool flag = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int column = 1; column <= rows; column++)
                {
                    maxColumn++;
                    Console.Write($"{maxColumn} ");
                    if (maxColumn==n)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
