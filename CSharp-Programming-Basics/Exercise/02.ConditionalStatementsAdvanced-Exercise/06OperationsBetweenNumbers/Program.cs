using System;

namespace _06OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operatorr = (Console.ReadLine());

            double result = 0.00;


            if (n2 == 0 && (operatorr =="/" || operatorr == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
             else if ( operatorr ==  "+" )
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - even");
                }
                else 
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - odd");
                }
            }
            else if (operatorr ==  "-" ) 
            {
                result = n1 - n2;
                if (n1 - n2 % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - odd");
                }
            }
            else if (operatorr == "*" )
            {
                result = n1 * n2;
                if (n1 * n2 % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operatorr} {n2} = {result} - odd");
                }
            }
            else if (operatorr == "/")
            {
                result = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (operatorr == "%")
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }

            
        }
    }
}
