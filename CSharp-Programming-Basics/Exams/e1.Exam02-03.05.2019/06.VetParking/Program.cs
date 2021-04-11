using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            
            double totalSum = 0.00;
            for (int iday = 1; iday <= days; iday++)
            {
                double sumForDay = 0.00;
                for (int ihour = 1; ihour <= hours; ihour++)
                {
                    if (iday%2==0 && ihour%2!=0)
                    {
                        sumForDay += 2.50;
                    }
                    else if (iday % 2 != 0 && ihour % 2 == 0)
                    {
                        sumForDay += 1.25;
                    }
                    else
                    {
                        sumForDay += 1;
                    }
                }
                totalSum += sumForDay;
                Console.WriteLine($"Day: {iday} - {sumForDay:F2} leva");
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
