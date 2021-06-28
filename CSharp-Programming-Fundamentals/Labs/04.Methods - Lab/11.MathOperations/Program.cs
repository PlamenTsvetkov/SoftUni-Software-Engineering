using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num1, operators, num2);
            Console.WriteLine(result);

        }

        private static double Calculate(int num1, char operators, int num2)
        {
            double result = 0;
            if (operators=='/')
            {
                result = num1 / num2;
            }
            else if (operators == '*')
            {
                result = num1 * num2;
            }
            else if (operators == '-')
            {
                result = num1 - num2;
            }
            else if (operators == '+')
            {
                result = num1 + num2;
            }
            return result;
        }
    }
}
