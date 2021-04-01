using System;

namespace _04.AnaWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;
            int stepsToHome = 0;
            int goal = 10000;
            
            while (input!="Going home")
            {
                
                int steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps>=goal)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if ((input == "Going home"))
            {
                stepsToHome = int.Parse(Console.ReadLine());
                totalSteps += stepsToHome;
            }            
            if (totalSteps>=goal)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal-totalSteps} more steps to reach goal.");
            }            
        }
    }
}
