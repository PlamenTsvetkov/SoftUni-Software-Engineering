using System;

namespace _03.Vacation
{
    class vacation
    {
        static void Main(string[] args)
        {
            double groupNum = double.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double priceSinglePerson = 0;
            if (day=="Friday")
            {
                if (typeGroup=="Students")
                {
                    priceSinglePerson = 8.45;
                }
                else if (typeGroup == "Business")
                {
                    priceSinglePerson = 10.90;
                }
                else if (typeGroup == "Regular")
                {
                    priceSinglePerson = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typeGroup == "Students")
                {
                    priceSinglePerson = 9.80;
                }
                else if (typeGroup == "Business")
                {
                    priceSinglePerson = 15.60;
                }
                else if (typeGroup == "Regular")
                {
                    priceSinglePerson = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (typeGroup == "Students")
                {
                    priceSinglePerson = 10.46;
                }
                else if (typeGroup == "Business")
                {
                    priceSinglePerson = 16;
                }
                else if (typeGroup == "Regular")
                {
                    priceSinglePerson = 22.50;
                }
            }
            double totalPrice = groupNum * priceSinglePerson;
            if (typeGroup=="Students" && groupNum>=30)
            {
                totalPrice *= 0.85;
            }
            else if (typeGroup == "Business" && groupNum >= 100)
            {
                totalPrice =totalPrice-10*priceSinglePerson;
            }
            else if (typeGroup == "Regular" && groupNum >= 10 && groupNum<=20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
