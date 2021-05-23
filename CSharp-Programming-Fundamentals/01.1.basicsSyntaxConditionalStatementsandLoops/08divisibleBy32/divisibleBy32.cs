using System;

namespace _08divisibleBy32
{
    class divisibleBy32
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
