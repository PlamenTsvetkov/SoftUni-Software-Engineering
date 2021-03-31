using System;

namespace _08AnaGraduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double clas = 1;
            double totalGrade = 0.00;
            int excluded = 0;

            while (clas <=12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade <4)
                {
                    excluded += 1;
                    grade = double.Parse(Console.ReadLine());
                    if (grade >=4)
                    {
                        excluded -= 1;
                    }
                    else if (grade < 4)
                    {
                        Console.WriteLine($"{name} has been excluded at {clas} grade");
                        break;
                    }
                }
                clas += 1;
                totalGrade += grade;
            }
            if (clas==13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {totalGrade / 12:f2}");
            }
        }
    }
}

