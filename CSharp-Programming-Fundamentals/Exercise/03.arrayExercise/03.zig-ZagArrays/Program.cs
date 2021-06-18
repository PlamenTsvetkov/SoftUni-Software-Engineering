using System;
using System.Linq;

namespace _03.zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] answer1 = new string[n];
            
            string[] answer2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                    
                if (i%2==0)
                {
                    answer1[i] = input[0];
                    answer2[i] = input[1];
                }
                else
                {
                    answer1[i] = input[1];
                    answer2[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(' ',answer1));
            Console.WriteLine(string.Join(' ', answer2));
        }
    }
}
