using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = "";
            string type = "";
            double totalStudent = 0;
            double totalStandart = 0;
            double totalKid = 0;
            double totalTicketForFilm = 0;
            double studentTicket = 0;
            double standartTicket = 0;
            double kidTicket = 0;

            while ((filmName = Console.ReadLine())!="Finish")
            {
                studentTicket = 0;
                standartTicket = 0;
                kidTicket = 0;
                double seats = double.Parse(Console.ReadLine());
                while ((type = Console.ReadLine())!="End")
                {
                    if (type== "student")
                    {
                        studentTicket += 1;
                        totalTicketForFilm += 1;
                    }
                    else if (type == "standard")
                    {
                        standartTicket += 1;
                        totalTicketForFilm += 1;
                    }
                    else if (type == "kid")
                    {
                        kidTicket += 1;
                        totalTicketForFilm += 1;
                    }
                    else if (totalTicketForFilm==seats)
                    {
                        Console.WriteLine($"{filmName} - {totalTicketForFilm / seats * 100:f2}% full");
                        break;
                    }
                    totalStudent += studentTicket;
                    totalStandart += totalStandart;
                    totalKid += kidTicket;
                }
            }
            Console.WriteLine($"Total tickets: {totalTicketForFilm}");
            Console.WriteLine($"{totalStudent / totalTicketForFilm * 100:F2}% student tickets.");
            Console.WriteLine($"{totalStandart / totalTicketForFilm * 100:F2}% student tickets.");
            Console.WriteLine($"{totalKid / totalTicketForFilm * 100:F2}% student tickets.");
        }
    }
}
