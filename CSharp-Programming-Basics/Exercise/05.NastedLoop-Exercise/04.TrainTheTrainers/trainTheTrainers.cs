using System;

namespace _04TrainTheTrainers
{
    class trainTheTrainers
    {
        static void Main(string[] args)
        {
            double jury = double.Parse(Console.ReadLine());
            string presentationName = "";
            double counter = 0;
            double absoluteGrade = 0;
            while ((presentationName = Console.ReadLine())!= "Finish")
            {
                double totalGrade = 0;
                for (int i = 0; i < jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                    counter++;
                    absoluteGrade += grade;
                }
                Console.WriteLine($"{presentationName} - {totalGrade / jury:f2}.");
            }
            Console.WriteLine($"Student's final assessment is {absoluteGrade/counter:f2}.");
        }
    }
}
