using System;
using System.Text.RegularExpressions;

namespace P2FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodesNum = int.Parse(Console.ReadLine());
            string pattern = @"(@#+)(?<product>[A-Z][a-zA-Z\d]{4,}[A-Z])(@#+)";
          
            for (int i = 0; i < barcodesNum; i++)
            {
                string currentBarcode = Console.ReadLine();
                var regex = Regex.Match(currentBarcode, pattern);
                if (regex.Success)
                {
                    string currentProduct = regex.Groups["product"].Value;
                    string productGroup = string.Empty;
                    for (int j = 0; j < currentProduct.Length; j++)
                    {
                        if (char.IsDigit(currentProduct[j]))
                        {
                            productGroup += currentProduct[j];
                        }
                        
                    }
                    if (productGroup==string.Empty)
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
