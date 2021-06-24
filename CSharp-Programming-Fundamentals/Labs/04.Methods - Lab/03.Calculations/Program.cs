using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (comand)
            {
                case "add":
                    PrintAdd(a,b);
                    break;
                case "multiply":
                    PrintMultiply(a,b);
                    break;
                case "substract":
                    PrintSubstract(a,b);
                    break;
                case "divide":
                    PrintDivide(a,b);
                    break;
                default:
                    break;
            }
           
            
        }

        private static void PrintDivide(int a, int b)
        {
            Console.WriteLine(a/b);
        }

        private static void PrintSubstract(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        private static void PrintMultiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        private static void PrintAdd(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
