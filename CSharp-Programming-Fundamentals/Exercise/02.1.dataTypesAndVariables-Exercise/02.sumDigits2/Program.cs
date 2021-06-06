using System;

namespace _02.sumDigits2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                //int currentNum = (int)char.GetNumericValue(num1[i]); Вариант 1
                int currentNum = int.Parse(num1[i].ToString());
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}
