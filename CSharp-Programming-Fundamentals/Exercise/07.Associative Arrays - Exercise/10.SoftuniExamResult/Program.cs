using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, Student> exams = new Dictionary<string, Student>();
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "exam finished")
            {
                List<string> data = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (data[1] == "banned")
                {
                    for (int i = students.Count - 1; i >= 0; i--)
                    {
                        if (students[i].Name == data[0])
                        {
                            students.RemoveAt(i);
                        }
                    }
                }
                else
                {
                    if (!exams.ContainsKey(data[1]))
                    {
                        Student student = new Student(data[0], int.Parse(data[2]));
                        students.Add(student);
                        exams.Add(data[1], 1);
                    }
                    else
                    {
                        if (students.Any(x => x.Name == data[0]))
                        {
                            if (students.Any(x => x.Point < int.Parse(data[2])) && students.Any(x => x.Point < int.Parse(data[2]))
                            {
                                for (int i = students.Count - 1; i >= 0; i--)
                                {
                                    if (students[i].Name == data[0])
                                    {
                                        students.RemoveAt(i);
                                    }
                                }
                                Student student = new Student(data[0], int.Parse(data[2]));
                                students.Add(student);
                                exams[data[1]]++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            Student student = new Student(data[0], int.Parse(data[2]));
                            students.Add(student);
                            exams[data[1]]++;
                        }
                    }
                }
            }
            Console.WriteLine("Results:");
            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x => x.Point).ThenBy(x => x.Name)));
            Console.WriteLine("Submissions:");
            foreach (var pair in exams.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
        class Student
        {
            public string Name { get; set; }
            public int Point { get; set; }
            public Student(string name, int point)
            {
                this.Name = name;
                this.Point = point;
            }
            public override string ToString()
            {
                return $"{Name} | {Point}";
            }
        }
    }
}

