using System;

namespace _02Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            double averageGrade = double.Parse(Console.ReadLine());

            if (averageGrade>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
