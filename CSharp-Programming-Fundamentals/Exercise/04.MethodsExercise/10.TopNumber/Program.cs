using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IsTopNumber(n);

        }

        private static void IsTopNumber(int n)
        {
            
            
            for (int i = 1; i < n; i++)
            {
                int sumDigit = 0;
                int oddNum = 0;
                bool isTopNumer = false;
                int currentNum = i;
                while (currentNum!=0)
                {
                    sumDigit += currentNum % 10;
                    if ((currentNum % 10)%2==1)
                    {
                        oddNum++;
                    }
                    currentNum /= 10;
                }
                if (sumDigit%8==0 && oddNum>0)
                {
                    isTopNumer = true;
                }
                if (isTopNumer)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
