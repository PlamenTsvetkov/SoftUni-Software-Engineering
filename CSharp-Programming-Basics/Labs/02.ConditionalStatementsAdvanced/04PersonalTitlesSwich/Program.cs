using System;
using System.Net.Http.Headers;

namespace _04PersonalTitlesSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (age <16)
            {
                switch (gender)
                {
                    case "m":
                        Console.WriteLine();
                    default:
                        break;
                }
            }


            
        }
    }
}
