using System;

namespace _03OddEvenPossition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumOdd = 0.00;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double sumEven = 0.00;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    double numOdd = double.Parse(Console.ReadLine());
                    sumOdd += numOdd;
                    if (minOdd>numOdd)
                    {
                        minOdd = numOdd;
                    }
                    if (maxOdd < numOdd)
                    {
                        maxOdd = numOdd;
                    }
                }
                else
                {
                    double numEven = double.Parse(Console.ReadLine());
                    sumEven += numEven;
                    if (minEven > numEven)
                    {
                        minEven = numEven;
                    }
                    if (maxEven < numEven)
                    {
                        maxEven = numEven;
                    }
                }
            }
            Console.WriteLine($"OddSum={sumOdd:F2},");
            if (minOdd== double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }
            if (maxOdd == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }
            Console.WriteLine($"EvenSum={sumEven:F2},");
            if (minEven == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }
            if (maxEven == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }

        }
    }
}
