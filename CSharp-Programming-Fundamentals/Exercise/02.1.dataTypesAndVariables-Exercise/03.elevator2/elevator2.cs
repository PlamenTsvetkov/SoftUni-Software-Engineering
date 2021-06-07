using System;

namespace _03.elevator2
{
    class elevator2
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling(n*1.0/p);
            Console.WriteLine(courses);
        }
    }
}
