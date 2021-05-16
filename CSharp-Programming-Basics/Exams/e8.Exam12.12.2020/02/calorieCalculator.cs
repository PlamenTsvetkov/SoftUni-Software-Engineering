using System;

namespace _02
{
    class calorieCalculator
    {
        static void Main(string[] args)
        {
            char gender = char.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double heightM = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            string activity =Console.ReadLine();

            double bhm = 0;
            double calories = 0;

            if (gender=='m')
            {
                bhm = 66 + (13.7 * kg) + (5 * heightM * 100) - (6.8 * age);
            }
            else
            {
                bhm = 655 + (9.6 * kg) + (1.8 * heightM * 100) - (4.7 * age);
            }

            if (activity=="sedentary")
            {
                calories = bhm * 1.2;
            }
            else if (activity == "lightly active")
            {
                calories = bhm * 1.375;
            }
            else if (activity == "moderately active")
            {
                calories = bhm * 1.55;
            }
            else if (activity == "very active")
            {
                calories = bhm * 1.725;
            }

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(calories)} calories per day.");
        }
    }
}
