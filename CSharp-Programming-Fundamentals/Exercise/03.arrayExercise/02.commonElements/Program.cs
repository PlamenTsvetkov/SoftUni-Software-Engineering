using System;

namespace _02.commonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr1 = Console.ReadLine().Split();
            string[] stringArr2 = Console.ReadLine().Split();
            for (int i = 0; i < stringArr2.Length; i++)
            {
                for (int j = 0; j < stringArr1.Length; j++)
                {
                    if (stringArr2[i]==stringArr1[j])
                    {
                        Console.Write($"{stringArr2[i]} ");
                    }
                }
            }
        }
    }
}
