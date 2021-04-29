using System;

namespace _03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            int prise = 0;
            if (color =="Red")
            {
                if (size=="Large")
                {
                    prise = 16;
                }
                else if (size == "Medium")
                {
                    prise = 13;
                }
                else if (size == "Small")
                {
                    prise = 9;
                }
            }
            else if (color == "Green")
            {
                if (size == "Large")
                {
                    prise = 12;
                }
                else if (size == "Medium")
                {
                    prise = 9;
                }
                else if (size == "Small")
                {
                    prise = 8;
                }
            }
            else if (color == "Yellow")
            {
                if (size == "Large")
                {
                    prise = 9;
                }
                else if (size == "Medium")
                {
                    prise = 7;
                }
                else if (size == "Small")
                {
                    prise = 5;
                }
            }
            double totalPrise = quantity * prise;
            double expenses = totalPrise * 35/100;
            double profit = totalPrise - expenses;
            Console.WriteLine($"{profit:F2} leva.");
        }
    }
}
