using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packet = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            bool isValid = false;
            double price = 0;
            int discount = 0;
            double totalPrice = 0;

            if ((town == "Bansko" || town =="Borovets") && packet=="withEquipment")
            {
                price = 100;
                discount = 10;
                isValid = true;
            }
            if ((town == "Bansko" || town == "Borovets") && packet == "noEquipment")
            {
                price = 80;
                discount = 5;
                isValid = true;
            }
            if ((town == "Varna" || town == "Burgas") && packet == "withBreakfast")
            {
                price = 130;
                discount = 12;
                isValid = true;
            }
            if ((town == "Varna" || town == "Burgas") && packet == "noBreakfast")
            {
                price = 100;
                discount = 7;
                isValid = true;
            }
            if (days>7)
            {
                days--;
            }
            if (vip=="yes")
            {
                totalPrice = (price * days)-((price * days) * discount / 100);
            }
            else
            {
                totalPrice = (price * days);
            }
            if (days<1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (isValid==false)
            {
                Console.WriteLine("Invalid input!");
            }
            else 
            {
                Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");
            }
        }
    }
}
