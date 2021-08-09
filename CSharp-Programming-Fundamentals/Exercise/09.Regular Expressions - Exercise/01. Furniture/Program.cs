using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<string> furnitures = new List<string>();
            double totalSum = 0;
            while ((input = Console.ReadLine()) != "Purchase")
            {

                string patern = @">>(?<name>.+)<<(?<price>\d+.*\d*)!(?<quantity>\d+)";
                var furniture = Regex.Match(input, patern);
                if (furniture.Success)
                {
                    furnitures.Add(furniture.Groups["name"].Value);
                    totalSum += double.Parse(furniture.Groups["price"].Value) * double.Parse(furniture.Groups["quantity"].Value);
                }

            }
            Console.WriteLine("Bought furniture:");
            if (furnitures.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furnitures));
            }
            
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
