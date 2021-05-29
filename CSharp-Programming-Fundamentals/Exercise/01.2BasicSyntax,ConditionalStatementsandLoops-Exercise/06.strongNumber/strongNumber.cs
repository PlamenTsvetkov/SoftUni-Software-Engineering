using System;

namespace _06.strongNumber
{
    class strongNumber
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int number = input;
            int currentNum = 0;
            int totalSum = 0;
            while (number!=0)
            {
                currentNum = number % 10;
                int factorial = 1;
                for (int i = 1; i <= currentNum; i++)
                {
                    factorial *= i;
                }
                totalSum += factorial;
                number /= 10;
            }
            if (totalSum==input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
