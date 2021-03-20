using System;

namespace _13SkiTrip2
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string tipeOfRoom = Console.ReadLine().ToLower();
            string grade = Console.ReadLine().ToLower();

            double nights = days - 1;
            double price = 0.00;
            double totalPrice = 0.00;


            if (days<10)
            {
                if (tipeOfRoom=="apartment")
                {
                    price = 25.00;
                    totalPrice = (nights * price) * 0.70;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    price = 35.00;
                    totalPrice = (nights * price) * 0.90;
                }
                else
                {
                    price = 18;
                    totalPrice = nights * price;
                }
            }
            else if (10<=days && days<= 15)
            {
                if (tipeOfRoom == "apartment")
                {
                    price = 25.00;
                    totalPrice = (nights * price) * 0.65;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    price = 35.00;
                    totalPrice = (nights * price) * 0.85;
                }
                else
                {
                    price = 18;
                    totalPrice = nights * price;
                }
            }
            else if (15 < days)
            {
                if (tipeOfRoom == "apartment")
                {
                    price = 25.00;
                    totalPrice = (nights * price) * 0.50;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    price = 35.00;
                    totalPrice = (nights * price) * 0.80;
                }
                else
                {
                    price = 18;
                    totalPrice = nights * price;
                }
            }
            if (grade=="positive")
            {
                totalPrice = totalPrice * 1.25;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else if (grade == "negative")
            {
                totalPrice = totalPrice * 0.90;
                Console.WriteLine($"{totalPrice:F2}");
            }
        }
    }
}
