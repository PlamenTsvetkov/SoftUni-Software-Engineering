﻿using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine().ToLower();
            string secondInput = Console.ReadLine().ToLower();
            int startIndex = 0;
            while (secondInput.Contains(firstInput))
            {
                int index = secondInput.IndexOf(firstInput,startIndex);
                secondInput=secondInput.Remove(index, firstInput.Length);
                
            }
            Console.WriteLine(secondInput);
        }
    }
}
