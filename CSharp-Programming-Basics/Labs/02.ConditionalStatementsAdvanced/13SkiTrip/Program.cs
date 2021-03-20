using System;

namespace _13SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string tipeOfRoom = Console.ReadLine().ToLower();
            string grade = Console.ReadLine().ToLower();

            double priceRFOP = 18;
            double priceApartment = 25.00;
            double pricePresidentApartment = 35.00;

            double nights = days - 1;
            double totalPriceApartment = 0.00;
            double totalPricePresidentApartment = 0.00;
            double totalPriceRFOP = priceRFOP * nights;



            if (days < 10)
            {
                if (tipeOfRoom == "apartment")
                {
                    totalPriceApartment = (priceApartment * nights) * 0.70 ;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    totalPricePresidentApartment = (pricePresidentApartment*nights) * 0.90;
                }
            }
            else if (10<=days &&  days <= 15)
            {
                if (tipeOfRoom == "apartment")
                {
                    totalPriceApartment = (priceApartment * nights) * 0.65;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    pricePresidentApartment = (pricePresidentApartment * nights) * 0.85;
                }
            }
            else if (15 < days)
            {
                if (tipeOfRoom == "apartment")
                {
                    totalPriceApartment = (priceApartment * nights) * 0.50;
                }
                else if (tipeOfRoom == "president apartment")
                {
                    totalPricePresidentApartment = (pricePresidentApartment * nights) * 0.80;
                }
            }
            if (grade == "positive")
            {
                totalPriceApartment = totalPriceApartment * 1.25;
                totalPricePresidentApartment = totalPricePresidentApartment * 1.25;
                totalPriceRFOP = totalPriceRFOP * 1.25;
            }
            else if (grade == "negative")
            {
                totalPriceApartment = totalPriceApartment * 0.9;
                totalPricePresidentApartment = totalPricePresidentApartment * 0.9;
                totalPriceRFOP = totalPriceRFOP * 0.9;
            }

            if (totalPriceApartment>0)
            {
                Console.WriteLine($"{totalPriceApartment:F2}");
            }
            else if (totalPricePresidentApartment > 0)
            {
                Console.WriteLine($"{totalPricePresidentApartment:F2}");
            }
            else if (totalPriceRFOP > 0)
            {
                Console.WriteLine($"{totalPriceRFOP:F2}");
            }

        }
    }
}
