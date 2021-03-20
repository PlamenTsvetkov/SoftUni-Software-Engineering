using System;

namespace _10InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
              double number = double.Parse(Console.ReadLine());
            
              bool valid = 100 <= number && number <= 200 || number == 0;
            
              if (!valid)
              {
                  Console.WriteLine("invalid");
              }
        }
    }
}
