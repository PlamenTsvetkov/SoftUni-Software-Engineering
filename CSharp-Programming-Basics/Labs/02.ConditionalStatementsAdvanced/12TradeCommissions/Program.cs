using System;

namespace _12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comision = 0.00;

            if (0<=sales && sales <= 500)
            {
                switch (town)
                {
                    case "sofia":
                        comision = 5;
                        break;
                    case "varna":
                        comision = 4.5;
                        break;
                    case "plovdiv":
                        comision = 5.5;
                        break;
                    default:
                        break;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                switch (town)
                {
                    case "sofia":
                        comision = 7;
                        break;
                    case "varna":
                        comision = 7.5;
                        break;
                    case "plovdiv":
                        comision = 8.0;
                        break;
                    default:
                        break;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                switch (town)
                {
                    case "sofia":
                        comision = 8;
                        break;
                    case "varna":
                        comision = 10.00;
                        break;
                    case "plovdiv":
                        comision = 12.00;
                        break;
                    default:
                        break;
                }
            }
            else if (10000 < sales)
            {
                switch (town)
                {
                    case "sofia":
                        comision = 12.00;
                        break;
                    case "varna":
                        comision = 13.00;
                        break;
                    case "plovdiv":
                        comision = 14.50;
                        break;
                    default:
                        break;
                }
            }
            double comisionSum = comision / 100 * sales;

            if (comision > 0)
            {
                Console.WriteLine( $"{comisionSum:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
