using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                string[] allCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string command = allCommand[0];
                if (command=="end")
                {
                    break;
                }
                if (command == "swap")
                {
                    int index1 = int.Parse(allCommand[1]);
                    int index2 = int.Parse(allCommand[2]);

                    int firstIndex = array[index1];
                    array[index1] = array[index2];
                    array[index2] = firstIndex;

                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(allCommand[1]);
                    int index2 = int.Parse(allCommand[2]);

                    int multiplyResult = array[index1]*array[index2];
                    array[index1] = multiplyResult;
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }

            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
