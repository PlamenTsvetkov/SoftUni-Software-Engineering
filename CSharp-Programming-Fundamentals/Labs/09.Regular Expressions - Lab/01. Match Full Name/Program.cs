using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            var result = regex.Matches(input);
            foreach (Match match in result)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
