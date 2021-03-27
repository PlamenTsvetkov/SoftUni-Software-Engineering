using System;

namespace _11NakovOddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишете n брой елемента : ");
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int oddMin = int.MaxValue;
            int oddMax = int.MinValue;
            int evenSum = 0;
            int evenMin = int.MaxValue;
            int evenMax = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write("num {0} = ",i);
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num> oddMax)
                    {
                        oddMax = num;
                    }
                }
                else
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }
            Console.WriteLine("OddSum="+oddSum);
            Console.WriteLine("OddMin=" + oddMin);
            Console.WriteLine("OddMax=" + oddMax);
            Console.WriteLine("EvenSum=" + evenSum);
            Console.WriteLine("EvenMin=" + evenMin);
            Console.WriteLine("EvenMax=" + evenMax);
        }
    }
}
