using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int mounth =int.Parse(Console.ReadLine());
            double price = 0.00;

            if (period =="one")
            {
                if (type=="Small")
                {
                    price = 9.98;
                }
                else if (type == "Middle")
                {
                    price = 18.99;
                }
                else if (type == "Large")
                {
                    price = 25.98;
                }
                else if (type == "ExtraLarge")
                {
                    price = 35.99;
                }
            }
            if (period == "two")
            {
                if (type == "Small")
                {
                    price = 8.58;
                }
                else if (type == "Middle")
                {
                    price = 17.09;
                }
                else if (type == "Large")
                {
                    price = 23.59;
                }
                else if (type == "ExtraLarge")
                {
                    price = 31.79;
                }
            }
            if (internet=="yes" && price <=10)
            {
                price += 5.50;
            }
            else if (internet == "yes" && price <= 30)
            {
                price += 4.35;
            }
            else if (internet == "yes" && price > 30)
            {
                price += 3.85;
            }
            if (period=="two")
            {
                price = price * 0.9625;
            }
            Console.WriteLine($"{price*mounth:f2} lv.");
        }
    }
}
