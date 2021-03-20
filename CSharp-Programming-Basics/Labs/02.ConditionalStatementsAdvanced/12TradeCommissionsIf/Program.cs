using System;

namespace _12TradeCommissionsIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comision = 0.00;

            if (0 <= sales && sales <=500)
            {
                if (town == "sofia")
                {
                    comision = 5.00;
                }
                else if (town == "varna")
                {
                    comision = 4.5;
                }
                else if (town == "plovdiv")
                {
                    comision = 5.5;
                }
            }
            else if (500 < sales && sales <= 1000)
            {
                if (town == "sofia")
                {
                    comision = 7.00;
                }
                else if (town == "varna")
                {
                    comision = 7.5;
                }
                else if (town == "plovdiv")
                {
                    comision = 8;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                if (town == "sofia")
                {
                    comision = 8.00;
                }
                else if (town == "varna")
                {
                    comision = 10.00;
                }
                else if (town == "plovdiv")
                {
                    comision = 12;
                }
            }
            else if (10000 < sales)
            {
                if (town == "sofia")
                {
                    comision = 12.00;
                }
                else if (town == "varna")
                {
                    comision = 13.00;
                }
                else if (town == "plovdiv")
                {
                    comision = 14.50;
                }
            }

            double sumComission = sales * comision / 100;
            if (sumComission>0)
            {
                Console.WriteLine($"{sumComission:F2}");
            }
            else
            {
                Console.WriteLine("error"); 
            }
        }
    }
}
