using System;

namespace _04.CinemaVaucher
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaucher = double.Parse(Console.ReadLine());
            string a = "";
            double aPrice = 0.00;
            double totalPrice = 0.00;
            int ticketSum = 0;
            int other = 0;
            while ((a = Console.ReadLine()) != "End")
            {
                aPrice = 0;
                if (a.Length >8)
                {                    
                    for (int i = 0; i < 2; i++)
                    {
                        aPrice += a[i];                                           
                    }
                    if (aPrice > vaucher - totalPrice)
                    {
                        break;
                    }
                    ticketSum += 1;
                }
                else if (a.Length<=8)
                {
                    aPrice = a[0];
                    if (aPrice > vaucher - totalPrice)
                    {
                        break;
                    }
                    other += 1;
                }                
                totalPrice += aPrice;                
            }
            Console.WriteLine(ticketSum);
            Console.WriteLine(other);
        }
    }
}
