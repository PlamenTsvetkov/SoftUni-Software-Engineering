using System;

namespace _09.spiceMustFlow
{
    class spiceMustFlow
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;
            if (startingYield>=100)
            {
                while (startingYield >= 100)
                {
                    days += 1;
                    totalAmount += startingYield - 26;
                    startingYield -= 10;
                }
                totalAmount -= 26;                
            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);

        }
    }
}
