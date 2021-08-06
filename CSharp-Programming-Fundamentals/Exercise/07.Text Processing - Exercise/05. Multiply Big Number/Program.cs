using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber == 0 || firstNumber=="")
            {
                Console.WriteLine(0);
                return;
            }
            
            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            for (int i = firstNumber.Length-1; i >= 0 ; i--)
            {
                int result = int.Parse(firstNumber[i].ToString()) * secondNumber+remainder;
                remainder = 0;
                if (result>9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }
               
                    sb.Append(result);
                             
                           
            }
            if (remainder != 0)
            {
                sb.Append(remainder);
            }
            StringBuilder finalresult = new StringBuilder();
            for (int i = sb.Length-1; i >= 0; i--)
            {
                finalresult.Append(sb[i]);
            }
            Console.WriteLine(finalresult);
        }
    }
}
