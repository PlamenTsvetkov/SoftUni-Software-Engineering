using System;

namespace _02.AnaExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrade = int.Parse(Console.ReadLine());
            string nameExercise = Console.ReadLine();
            
            double sumGrade = 0.00;
            string lastProblem = "";
            int poorGradeMarin = 0;
            bool isMarinPoorGrade = false;
            int numGrade = 0;
            int numProblem = 0;



            while (nameExercise != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrade += grade;
                numGrade += 1;
                numProblem += 1;
                lastProblem = nameExercise;
                if (grade <=4)
                {
                    poorGradeMarin += 1;
                    if (poorGradeMarin == poorGrade)
                    {
                        isMarinPoorGrade = true;
                        break;
                    }
                }
                nameExercise = Console.ReadLine();
                 
            }
            if (isMarinPoorGrade)
            {
                Console.WriteLine($"You need a break, {poorGradeMarin} poor grades."); 
            }
            else
            {
                Console.WriteLine($"Average score: {sumGrade / numGrade:F2}");
                Console.WriteLine($"Number of problems: {numProblem}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }

        }
    }
}
