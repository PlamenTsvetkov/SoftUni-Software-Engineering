using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {//\b[+359]+([ ,-])2\1\d{3}\1\d{4}\b
            string input = Console.ReadLine();
            string pattern = @"\+359([\s-])[2]\1\d{3}\1\d{4}\b";
            var phones = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
