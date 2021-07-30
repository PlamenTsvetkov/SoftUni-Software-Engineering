using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrade = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrade.ContainsKey(studentName))
                {
                    studentGrade.Add(studentName, new List<double> {grade});
                }
                else
                {
                    studentGrade[studentName].Add(grade);
                }
            }
            foreach (var pair in studentGrade.OrderByDescending(x=>x.Value.Average()))
            {
                if (pair.Value.Average()>=4.5)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value.Average():f2}");
                }
            }
            

        }
    }
}
