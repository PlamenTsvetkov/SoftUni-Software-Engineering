using System;

namespace _04.AnaSequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            int b = 1;
            while (b <= a)
            {
                Console.WriteLine(b);
                b = b * 2 + 1;
            }
        }
    }
}
