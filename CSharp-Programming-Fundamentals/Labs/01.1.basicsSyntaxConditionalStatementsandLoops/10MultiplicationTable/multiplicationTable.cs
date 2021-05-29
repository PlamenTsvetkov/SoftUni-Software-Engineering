using System;

namespace _10MultiplicationTable
{
    class multiplicationTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            while (times != 11)
            {
                Console.WriteLine($"{n} X {times} = {n*times}");
                times += 1;
            }
           
        }
    }
}
