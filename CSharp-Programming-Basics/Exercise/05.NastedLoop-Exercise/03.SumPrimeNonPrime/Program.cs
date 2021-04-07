using System;

namespace _03SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
           
            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (number == 1)
                {
                    sumNonPrime+=number;
                }
                else if (number == 2)
                {
                    sumPrime+=number;
                }
                else if (number % 2 == 0)
                {
                    sumNonPrime += number; 
                }
                else
                {
                    int boundary = (int)Math.Floor(Math.Sqrt(number));
                    bool isPrime = true;
                    for (int i = 3; i <= boundary; i+=2)
                    {
                        if (number%i==0)
                        {
                            isPrime = false;
                            break;
                        }
                        
                    }
                    if (isPrime)
                    {
                        sumPrime += number;
                    }
                    else
                    {
                        sumNonPrime += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
