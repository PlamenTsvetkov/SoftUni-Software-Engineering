using System;

namespace _10.lowerOrUpper
{
    class lowerOrUpper
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());

            if (char.IsLower(char1))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(char1))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
