using System;

namespace _10.MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(a);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int a)
        {
            int result = GetSumOfEvenDigits(a)*GetSumOfOddDigits(a);
            return result;
        }

        private static int GetSumOfOddDigits(int a)
        {
            int result = 0;
            int currentSymvol = 0;
            while (a != 0)
            {
                currentSymvol = a % 10;
                if (currentSymvol % 2 == 1)
                {
                    result += currentSymvol;
                }
                a /= 10;

            }
            return result;
        }

        private static int GetSumOfEvenDigits(int a)
        {
            int result = 0;
            int currentSymvol = 0;
            while (a!=0)
            {
                currentSymvol = a % 10;
                if (currentSymvol%2==0)
                {
                    result += currentSymvol;
                }
                a /= 10;

            }
            return result;
        }

        
    }
}
