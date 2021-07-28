using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> minetTask = new Dictionary<string, int>();
            while ((input = Console.ReadLine())!="stop")
            {
                string keys = input;
                int value = int.Parse(Console.ReadLine());
                if (!minetTask.ContainsKey(keys))
                {
                    minetTask.Add(keys, value);
                }
                else
                {
                    minetTask[keys] += value;
                }
                
            }
            foreach (var pair in minetTask)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
