using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantityTotal = double.Parse(Console.ReadLine());
            string quantity = "";
            double person = 0.00;
            double totalPerson = 0.00;
            double totalSum = 0.00;
            while ((quantity= Console.ReadLine())!="Movie time!")
            {
                person = double.Parse(quantity);
                if (totalPerson+person>quantityTotal)
                {
                    Console.WriteLine($"The cinema is full.");
                    break;
                }
                totalPerson += person;
                if (person%3==0)
                {
                    totalSum += (person * 5) - 5;
                }
                else 
                {
                    totalSum += person * 5;
                }
            }
            if (quantity== "Movie time!")
            {
                Console.WriteLine($"There are {quantityTotal-totalPerson} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {totalSum} lv.");
        }
    }
}
