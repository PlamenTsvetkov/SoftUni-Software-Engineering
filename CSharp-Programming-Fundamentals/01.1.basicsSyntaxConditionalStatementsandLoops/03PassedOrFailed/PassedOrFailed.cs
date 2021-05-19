using System;

namespace _03PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main(string[] args)
        {
            double averageGrade = double.Parse(Console.ReadLine());

            if (averageGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
