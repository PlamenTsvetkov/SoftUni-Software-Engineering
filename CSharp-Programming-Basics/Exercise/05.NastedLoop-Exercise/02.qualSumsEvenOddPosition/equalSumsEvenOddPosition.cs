using System;

namespace _02equalSumsEvenOddPosition
{
    class equalSumsEvenOddPosition
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            
            for (int i = n1; i <= n2; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDiggit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += currentDiggit;
                    }
                    else
                    {
                        oddSum += currentDiggit;
                    }
                }
                if (oddSum==evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
