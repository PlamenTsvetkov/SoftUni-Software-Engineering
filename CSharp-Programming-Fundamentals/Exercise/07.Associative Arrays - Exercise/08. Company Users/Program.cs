using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, List<string>> companyID = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> inputData = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!companyID.ContainsKey(inputData[0]))
                {
                    companyID.Add(inputData[0], new List<string> { inputData[1] });
                }
                else
                {
                    if (!companyID[inputData[0]].Contains(inputData[1]))
                    {
                        companyID[inputData[0]].Add(inputData[1]);
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            foreach (var pair in companyID.OrderBy(pair => pair.Key))
            {
                Console.WriteLine($"{pair.Key}");
                foreach (var ID in pair.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
