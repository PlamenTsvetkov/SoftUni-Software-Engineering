using System;

namespace _02.sumDigits
{
    class sumDigits
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num1!=0)
            {
                sum += num1 % 10;
                num1 = num1 / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
