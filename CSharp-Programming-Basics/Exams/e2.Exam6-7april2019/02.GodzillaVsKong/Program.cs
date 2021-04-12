using System;

namespace _02.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
           double statist = double.Parse(Console.ReadLine());
           double dress = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalDress = statist * dress;

            if (statist>150)
            {
                totalDress = totalDress * 0.90;
            }
            double totalExpenses = totalDress + decor;
            if (budget>=totalExpenses)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-totalExpenses:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalExpenses-budget:f2} leva more.");
            }
        }
    }
}
