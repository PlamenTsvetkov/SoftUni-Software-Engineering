using System;

namespace _02equalSumsEvenOddPosition2
{
    class equalSumsEvenOddPosition2
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            
            for (int i = number1; i <= number2; i++)
            {
                int totalOdd = 0;
                int totalEven = 0;
                string stringNumber = i.ToString();
                for (int j = 0; j < stringNumber.Length; j++)
                {
                    int result = int.Parse(stringNumber[j].ToString());
                    if (j%2==0)
                    {

                        totalEven += result;
                    }

                    if (j % 2 == 1)
                    {
                        totalOdd += result;
                    }
                }
                if (totalEven==totalOdd)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
