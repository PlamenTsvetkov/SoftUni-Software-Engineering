using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityPensil = double.Parse(Console.ReadLine());
            double quantityMarkers = double.Parse(Console.ReadLine());
            double literPreparat = double.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double pricePensil = 5.80;
            double priceMarkers = 7.20;
            double pricePreparat = 1.20;

            double totalPricePensil = quantityPensil * pricePensil;
            double totalPriceMarkers = quantityMarkers*priceMarkers;
            double totalPricePreparat = literPreparat*pricePreparat;

            double totalPrice = totalPricePensil + totalPriceMarkers + totalPricePreparat;

            double totalPriceDiscount = totalPrice - (totalPrice * percentDiscount / 100);
            Console.WriteLine($"{totalPriceDiscount:F3}");

        }
    }
}
