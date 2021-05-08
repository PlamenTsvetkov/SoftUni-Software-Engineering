using System;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilm = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int ticketNum = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double totalDaySum = ticketNum * ticketPrice;
            double totalSumPeriod = totalDaySum * days;
            double cinemaExpenses = totalSumPeriod * percent / 100;
            double profit = totalSumPeriod - cinemaExpenses;
            Console.WriteLine($"The profit from the movie {nameFilm} is {profit:f2} lv.");
        }
    }
}
