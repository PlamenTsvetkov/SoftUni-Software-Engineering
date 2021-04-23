using System;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double gradeA = 0;
            double gradeB = 0;

            if (country=="Russia")
            {
                if (device=="ribbon")
                {
                    gradeA = 9.100;
                    gradeB = 9.400;
                }
                else if (device == "hoop")
                {
                    gradeA = 9.300;
                    gradeB = 9.800;
                }
                else if (device == "rope")
                {
                    gradeA = 9.600;
                    gradeB = 9.000;
                }
            }
            if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    gradeA = 9.600;
                    gradeB = 9.400;
                }
                else if (device == "hoop")
                {
                    gradeA = 9.550;
                    gradeB = 9.750;
                }
                else if (device == "rope")
                {
                    gradeA = 9.500;
                    gradeB = 9.400;
                }
            }
            if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    gradeA = 9.200;
                    gradeB = 9.500;
                }
                else if (device == "hoop")
                {
                    gradeA = 9.450;
                    gradeB = 9.350;
                }
                else if (device == "rope")
                {
                    gradeA = 9.700;
                    gradeB = 9.150;
                }
            }
            double totalGrade = gradeA + gradeB;
            double grade = 20;
            Console.WriteLine($"The team of {country} get {totalGrade:F3} on {device}.");
            Console.WriteLine($"{((grade-totalGrade)/grade)*100:F2}%");
        }
    }
}
