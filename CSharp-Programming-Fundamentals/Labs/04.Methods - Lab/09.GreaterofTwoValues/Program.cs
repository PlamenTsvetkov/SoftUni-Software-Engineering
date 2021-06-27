using System;

namespace _09.GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMaxInt(a, b);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
               char a =char.Parse(Console.ReadLine());
               char b =char.Parse(Console.ReadLine());
                char result = GetMaxChar(a, b);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
               string a =Console.ReadLine();
               string b =Console.ReadLine();
                string result = GetMaxString(a, b);
                Console.WriteLine(result);
            }


        }

        private static string GetMaxString(string a, string b)
        {
            string result = string.Empty;
            if (a.CompareTo(b)>0)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }

        private static char GetMaxChar(char a, char b)
        {
            char result = (char)0x00;
            if (a>b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }

        private static int GetMaxInt(int a, int b)
        {
            int result = Math.Max(a,b);
            return result;

        }
    }
}
