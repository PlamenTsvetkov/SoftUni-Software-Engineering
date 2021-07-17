using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine())!="end")
            {
                List<string> curentStudent = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                Student student = new Student(curentStudent[0], curentStudent[1], int.Parse(curentStudent[2]), curentStudent[3]);
                students.Add(student);

            }
            string currentTown = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine,students.Where(x=>x.HomeTown==currentTown)));
        }
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }
            public override string ToString()
            {
                return $"{FirstName} {LastName} is {Age} years old."; 
            }
        }

    }
}
