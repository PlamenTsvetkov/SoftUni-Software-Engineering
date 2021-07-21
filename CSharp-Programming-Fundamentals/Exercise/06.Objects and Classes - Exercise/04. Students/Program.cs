using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                Students student = new Students(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                students.Add(student);
            }
            
            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }
        public class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
            public Students(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:f2}";
            }
        }
    }
}

