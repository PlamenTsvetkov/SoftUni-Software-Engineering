using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double totalIncome = 0;
            while ((input=Console.ReadLine())!= "end of shift")
            {
                string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*\d*)\$";
                var regex = Regex.Match(input, pattern);
                if (regex.Success)
                {
                    string customer = regex.Groups["customer"].Value;
                    string product = regex.Groups["product"].Value;
                    int count = int.Parse(regex.Groups["count"].Value);
                    double price = double.Parse(regex.Groups["price"].Value);
                    double totalPrice = count * price;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
