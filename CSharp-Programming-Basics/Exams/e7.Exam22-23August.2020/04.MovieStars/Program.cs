using System;

namespace _04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string nameActior = "";
            double salary = 0.00;
            double totalSalary = 0.00;
            double currentBudget = budget;
            while ((nameActior=Console.ReadLine()) !="ACTION")
            {
                if (nameActior.Length>15)
                {
                    salary = currentBudget * 0.2;
                }
                else 
                {
                    salary = double.Parse(Console.ReadLine());
                }
                totalSalary += salary;
                if (currentBudget-salary<0)
                {
                    break;
                }
                currentBudget -= salary;
            }
            if (budget-totalSalary>=0)
            {
                Console.WriteLine($"We are left with {currentBudget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {totalSalary - budget:f2} leva for our actors.");
            }
        }
    }
}
