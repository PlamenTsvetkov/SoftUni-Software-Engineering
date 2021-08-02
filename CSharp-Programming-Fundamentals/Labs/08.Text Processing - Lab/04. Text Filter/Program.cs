using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();
            for (int i = 0; i < banList.Length; i++)
            {
                string replacement = new string('*', banList[i].Length);
                text = text.Replace(banList[i], replacement);
            }
            Console.WriteLine(text);
        }
    }
}
