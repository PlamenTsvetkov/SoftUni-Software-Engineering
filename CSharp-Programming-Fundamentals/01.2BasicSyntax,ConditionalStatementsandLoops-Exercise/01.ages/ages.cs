using System;

namespace _01.ages
{
    class ages
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <=2)
            {
                Console.WriteLine("baby");
            }
            else if (3<=num && num <= 13)
            {
                Console.WriteLine("child");
            }
            else if (14 <= num && num <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (20 <= num && num <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (66 <= num)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
