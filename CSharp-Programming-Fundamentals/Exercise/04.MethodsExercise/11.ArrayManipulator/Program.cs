using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input = string.Empty;
            //Console.WriteLine(string.Join(',', array));
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(array, index);
                }
                else if (command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(array) == -1)
                        {
                            Console.WriteLine("No maches");
                        }
                        Console.WriteLine(MaxEven(array));
                    }
                    else
                    {
                        if (MaxOdd(array) == -1)
                        {
                            Console.WriteLine("No maches");
                        }
                        Console.WriteLine(MaxOdd(array));
                    }
                }
                else if (command[0] == "min")
                {
                    if (command[1] == "even")
                    {
                        if (MinEven(array) == -1)
                        {
                            Console.WriteLine("No maches");
                        }
                        Console.WriteLine(MinEven(array));
                    }
                    else
                    {
                        if (MinOdd(array) == -1)
                        {
                            Console.WriteLine("No maches");
                        }
                        Console.WriteLine(MinOdd(array));
                    }
                }
                else if (command[0] == "first")
                {
                    int count = int.Parse(command[1]);
                    if (command[2] == "even")
                    {
                        ReturnFirstEven(array, count);
                    }
                    else
                    {

                    }
                }
            }
        }

        private static void ReturnFirstEven(int[] array, int count)
        {
            string numbers = string.Empty;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    numbers += array[i] + " ";
                    counter++;

                }
                if (counter == count)
                {
                    break;
                }
            }
            var result = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
        }
        private static int MinOdd(int[] array)
        {
            int minOdd = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] <= minOdd)
                    {
                        minOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        private static int MinEven(int[] array)
        {
            int minEven = int.MaxValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] <= minEven)
                    {
                        minEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        private static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        private static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        private static void Exchange(int[] array, int index)
        {
            int[] firstArray = new int[array.Length - index - 1];
            int[] secondArray = new int[index + 1];

            int firstArrCounter = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                firstArray[firstArrCounter] = array[i];
                firstArrCounter++;
            }
            for (int i = 0; i < index + 1; i++)
            {
                secondArray[i] = array[i];
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                array[i] = firstArray[i];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                array[firstArray.Length + i] = secondArray[i];
            }
        }
    }
}
