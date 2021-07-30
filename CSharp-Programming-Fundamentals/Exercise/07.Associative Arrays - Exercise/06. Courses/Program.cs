using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while ((input=Console.ReadLine())!="end")
            {
                List<string> inputData = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!courses.ContainsKey(inputData[0]))
                {
                   
                    courses.Add(inputData[0], new List<string> { inputData[1] });
                }
                else
                {
                    courses[inputData[0]].Add(inputData[1]);
                }
            }
            foreach (var pair in courses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");
                foreach (var name in pair.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
