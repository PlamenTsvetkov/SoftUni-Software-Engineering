using System;

namespace _03.OscarWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();   
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double filmPrice = 0.00;

            if (nameFilm=="A Star Is Born")
            {
                if (type=="normal")
                {
                    filmPrice = 7.50;
                }
                else if (type == "luxury")
                {
                    filmPrice = 10.50;
                }
                else if (type == "ultra luxury")
                {
                    filmPrice = 13.50;
                }
            }
            else if (nameFilm == "Bohemian Rhapsody")
            {
                if (type == "normal")
                {
                    filmPrice = 7.35;
                }
                else if (type == "luxury")
                {
                    filmPrice = 9.45;
                }
                else if (type == "ultra luxury")
                {
                    filmPrice = 12.75;
                }
            }
            else if (nameFilm == "Green Book")
            {
                if (type == "normal")
                {
                    filmPrice = 8.15;
                }
                else if (type == "luxury")
                {
                    filmPrice = 10.25;
                }
                else if (type == "ultra luxury")
                {
                    filmPrice = 13.25;
                }
            }
            else if (nameFilm == "The Favourite")
            {
                if (type == "normal")
                {
                    filmPrice = 8.75;
                }
                else if (type == "luxury")
                {
                    filmPrice = 11.55;
                }
                else if (type == "ultra luxury")
                {
                    filmPrice = 13.95;
                }
            }
            double totalIncome = quantity * filmPrice;
            Console.WriteLine($"{nameFilm} -> {totalIncome:F2} lv.");
        }
    }
}
