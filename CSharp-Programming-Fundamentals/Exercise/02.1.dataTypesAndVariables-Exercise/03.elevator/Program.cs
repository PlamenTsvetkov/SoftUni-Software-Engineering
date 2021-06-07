using System;

namespace _03.elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            float courses = n / p ;
            if (n%p!=0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);


        }
    }
}
