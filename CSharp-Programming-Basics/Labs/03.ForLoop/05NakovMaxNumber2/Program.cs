using System;

namespace _05NakovMaxNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current> maxNum)
                {
                    maxNum = current;
                }
                if (current <minNum)
                {
                    minNum = current;
                }
            }
        }
    }
}
