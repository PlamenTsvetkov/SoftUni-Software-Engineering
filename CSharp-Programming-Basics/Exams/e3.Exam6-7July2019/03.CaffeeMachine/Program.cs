using System;

namespace _03.CaffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();   
            string sugar = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double typePrice = 0.00;

            if (type=="Espresso")
            {
                if (sugar=="Without")
                {
                    typePrice = 0.90;
                }
                else if (sugar == "Normal")
                {
                    typePrice = 1.00;
                }
                else if (sugar == "Extra")
                {
                    typePrice = 1.20;
                }
            }
            else if (type == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    typePrice = 1.00;
                }
                else if (sugar == "Normal")
                {
                    typePrice = 1.20;
                }
                else if (sugar == "Extra")
                {
                    typePrice = 1.60;
                }
            }
            else if (type == "Tea")
            {
                if (sugar == "Without")
                {
                    typePrice = 0.50;
                }
                else if (sugar == "Normal")
                {
                    typePrice = 0.60;
                }
                else if (sugar == "Extra")
                {
                    typePrice = 0.70;
                }
            }
            double totalPrice = typePrice * quantity;
            if (sugar =="Without")
            {
                totalPrice = totalPrice * 0.65;
            }
            if (type=="Espresso" && quantity>=5)
            {
                totalPrice = totalPrice * 0.75;
            }
            if (totalPrice>15)
            {
                totalPrice = totalPrice * 0.80;
            }
            Console.WriteLine($"You bought {quantity} cups of {type} for {totalPrice:F2} lv.");
        }
    }
}
