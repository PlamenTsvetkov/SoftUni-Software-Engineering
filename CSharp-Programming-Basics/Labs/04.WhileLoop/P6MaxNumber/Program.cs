using System;

namespace _06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNum = int.MinValue;

            while (input != "Stop")
            {
                 int number = int.Parse(input);
                if (number>maxNum)
                {
                    maxNum = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
