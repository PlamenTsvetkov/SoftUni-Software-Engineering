using System;
using System.Text;

namespace _07.repeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = GetString(str, n);
            Console.WriteLine(result);
        }

        private static string GetString(string str, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
