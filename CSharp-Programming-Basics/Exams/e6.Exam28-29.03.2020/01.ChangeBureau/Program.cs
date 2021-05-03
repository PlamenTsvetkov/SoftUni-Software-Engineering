using System;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityBitcoin = double.Parse(Console.ReadLine());
            double quantityIoan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double bitkoinLeva = 1168;
            double ioanDolars = 0.15;
            double dolarLeva = 1.76;
            double evroLeva = 1.95;

            double quantitiLevafromBitkoin = quantityBitcoin * bitkoinLeva;
            double quantityDolarFromIoan = quantityIoan * ioanDolars;
            double quantitiLevaFromDolar = quantityDolarFromIoan * dolarLeva;
            double quantityEvrofromLeva = (quantitiLevafromBitkoin + quantitiLevaFromDolar) / evroLeva;
            double quantityComision = quantityEvrofromLeva * comision / 100;
            Console.WriteLine($"{quantityEvrofromLeva - quantityComision:f2}");
        }
    }
}
