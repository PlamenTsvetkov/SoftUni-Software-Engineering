using System;

namespace _05
{
    class christmasGifts
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int adults= 0;
            int kids = 0;
            double toyPrice = 5;
            double sweaterPrice = 15;


            while (input!="Christmas")
            {
                int ageFamilyMember = int.Parse(input);
                if (ageFamilyMember<=16)
                {
                    kids++;
                }
                else
                {
                    adults++;
                }
                input = Console.ReadLine();
            }
            double moneyForToys = toyPrice * kids;
            double moneyForSweaters = sweaterPrice * adults;

            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");
        }
    }
}
