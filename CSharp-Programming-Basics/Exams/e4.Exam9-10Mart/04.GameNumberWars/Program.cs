using System;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            int numberWarpoint1 = 0;
            int numberWarPoint2 = 0;
            int totalPoint1 = 0;
            int totalPoint2 = 0;
            
            string input = "";
            string winnerNumberWars = "";

            while ((input = Console.ReadLine()) != "End of game")
            {
                int pointName1 = 0;
                int pointName2 = 0;
                pointName1 = int.Parse(input);
                pointName2 = int.Parse(Console.ReadLine());
                if (pointName1>pointName2)
                {
                    totalPoint1 += pointName1 - pointName2;
                }
                else if (pointName2>pointName1)
                {
                    totalPoint2 += pointName2 - pointName1;
                }
                else if (pointName1==pointName2)
                {
                   numberWarpoint1 =int.Parse(Console.ReadLine());
                   numberWarPoint2 =int.Parse(Console.ReadLine());
                    if (numberWarpoint1>numberWarPoint2)
                    {
                        winnerNumberWars = name1;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{winnerNumberWars} is winner with {totalPoint1} points");
                        break;
                    }
                    else if (numberWarPoint2>numberWarpoint1)
                    {
                        winnerNumberWars = name2;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{winnerNumberWars} is winner with {totalPoint2} points");
                        break;
                    }
                }
            }
            if (input =="End of game")
            {
                Console.WriteLine($"{name1} has {totalPoint1} points");
                Console.WriteLine($"{name2} has {totalPoint2} points");
            }
        }
    }
}
