using System;
using System.Collections.Generic;

namespace _04.ListofProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                productList.Add(Console.ReadLine());
            }
            productList.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}.{productList[i]}");
            }
        }
    }
}
