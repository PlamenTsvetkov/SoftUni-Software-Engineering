using System;

namespace _06.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double dressPriceForOneStatist = double.Parse(Console.ReadLine());

            double dekor = budget * 0.1;
            double dressPrice = dressPriceForOneStatist * statisti;

            if (statisti > 150 )
            {
                dressPrice =  dressPrice *  0.9;
            }
           
            double finalSum = budget - dressPrice - dekor;

            if (finalSum < 0)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(finalSum):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {finalSum:F2} leva left.");
            }

        }
    }
}
