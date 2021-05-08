using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());

            double totalMoney = 0;
            
            string sport = "";
            double dayWin = 0;
            double dayLose = 0;

            for (int i = 0; i < days; i++)
            {
                double dayMoney = 0;
                double win = 0;
                double lose = 0;
                while ((sport = Console.ReadLine()) != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result=="win")
                    {
                        win += 1;
                        dayMoney += 20;
                    }
                    else if (result == "lose")
                    {
                        lose += 1;
                    }
                }
                if (win>lose)
                {
                    dayWin += 1;
                    dayMoney = dayMoney * 1.1;
                }
                else
                {
                    dayLose += 1;
                }
                totalMoney += dayMoney;
            }
            if (dayWin>dayLose)
            {
                totalMoney = totalMoney * 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");    
            }
        }
    }
}
