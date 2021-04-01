using System;

namespace _01.AnaOldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();

            string books = Console.ReadLine();
            int search = 0;

            while (books != "No More Books")
            {
                if (bookName == books)
                {
                    Console.WriteLine($"You checked {search} books and found it.");
                    break;
                }
                search += 1;
                books = Console.ReadLine();
            }
            if (books == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {search} books.");
            }
        }
    }
}
