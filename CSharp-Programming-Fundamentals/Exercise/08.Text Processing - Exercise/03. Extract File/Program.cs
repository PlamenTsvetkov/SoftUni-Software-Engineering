using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pathFile = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> fileNameExtension = pathFile[pathFile.Count - 1]
                .Split(".", StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine($"File name: {fileNameExtension[0]}");
            Console.WriteLine($"File extension: {fileNameExtension[1]}");
        }
    }
}
