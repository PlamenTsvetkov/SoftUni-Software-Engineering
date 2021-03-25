using System;

namespace _07NakovLeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете n числа: ");
            int n = int.Parse(Console.ReadLine());

            int value1 = 0;
            int value2 = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("num {0} = ",i);
                int num1 = int.Parse(Console.ReadLine());
                value1 += num1;
            }
            for (int x = 1; x <= n; x++)
            {
                Console.Write("num {0} = ", x);
                int num2 = int.Parse(Console.ReadLine());
                value2 += num2;
            }
            double difference = value1 - value2;
            if (value1==value2)
            {
                Console.WriteLine("Yes, sum = " + value1);
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(difference)}");
            }
        }
    }
}
