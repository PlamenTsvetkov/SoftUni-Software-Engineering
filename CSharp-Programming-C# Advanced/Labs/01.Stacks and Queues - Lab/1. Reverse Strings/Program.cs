using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();
            //var reverseText = new Stack<char>(text);
            var reverseText = new Stack<char>(Console.ReadLine());
            while (reverseText.Any())
            {
                Console.Write(reverseText.Pop());
            }
        }
    }
}
