using System;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            string type = "";
            int unsuccesful = 0;
            int startPoint = 301;
            int succesful = 0;
            while ((type = Console.ReadLine())!= "Retire")
            {                
                
                int currentPoint = int.Parse(Console.ReadLine());
                if (type =="Single")
                {
                    currentPoint = currentPoint;
                }
                else if (type == "Double")
                {
                    currentPoint = 2*currentPoint;
                }
                else if (type == "Triple")
                {
                    currentPoint = 3 * currentPoint;
                }
                if (currentPoint<=startPoint)
                {
                    succesful += 1;
                    startPoint -= currentPoint;
                }
                else if (currentPoint > startPoint)
                {
                    unsuccesful += 1;
                    continue;
                }
                if (startPoint==0)
                {
                    break;
                }
            }
            if (startPoint==0)
            {
                Console.WriteLine($"{namePlayer} won the leg with {succesful} shots.");
            }
            else
            {
                Console.WriteLine($"{namePlayer} retired after {unsuccesful} unsuccessful shots.");
            }
        }
    }
}
