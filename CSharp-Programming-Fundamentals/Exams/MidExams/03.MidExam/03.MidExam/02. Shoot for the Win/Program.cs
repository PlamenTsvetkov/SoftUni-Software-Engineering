using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            int shotCounter = 0;
            while ((input=Console.ReadLine())!="End")
            {
                int arrayLenght = array.Length;
                int index = int.Parse(input);
                if (index>=0 && index<arrayLenght && array[index]!=-1)
                {
                    int currentIndexValue = array[index];
                    array[index] = -1;
                    shotCounter++;
                    for (int i = 0; i < arrayLenght; i++)
                    {
                        if (array[i]==-1)
                        {
                            continue;
                        }
                        else if (array[i] > currentIndexValue)
                        {
                            array[i] -= currentIndexValue;
                        }
                        else
                        {
                            array[i] += currentIndexValue;
                        }
                    }
                    
                }                          


            }
            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ", array)}");

        }
    }
}
