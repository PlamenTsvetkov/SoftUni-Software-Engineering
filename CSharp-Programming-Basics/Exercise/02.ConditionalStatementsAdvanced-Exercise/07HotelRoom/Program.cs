using System;

namespace _07HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double nights = double.Parse(Console.ReadLine());

            double priceStudioforNight = 0.00;
            double priceApartmentForNight = 0.00;



            if (month == "may" || month == "october")
            {
                priceStudioforNight = 50;
                priceApartmentForNight = 65;
                if ((nights) > 7 && nights <= 14)
                {
                    priceStudioforNight = priceStudioforNight * 0.95;
                }
                else if ((nights) > 14)
                {
                    priceStudioforNight = priceStudioforNight * 0.70;
                    priceApartmentForNight = priceApartmentForNight * 0.90;
                }
            }
            else if (month == "june" || month == "september")
            {
                priceStudioforNight = 75.20;
                priceApartmentForNight = 68.70;
                if ((nights) > 14)
                {
                    priceStudioforNight = priceStudioforNight * 0.80;
                    priceApartmentForNight = priceApartmentForNight * 0.90;
                }
            }
            else if (month == "july" || month == "august")
            {
                priceStudioforNight = 76.00;
                priceApartmentForNight = 77.00;
                if (nights > 14)
                {
                    priceApartmentForNight = priceApartmentForNight * 0.90;
                }
            }
            double totalSumStudio = priceStudioforNight * nights;
            double totalSumApartment = priceApartmentForNight * nights;
            
            Console.WriteLine($"Apartment: {totalSumApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalSumStudio:F2} lv.");
        }
    }
}
