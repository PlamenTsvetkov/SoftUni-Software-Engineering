using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();
            string input = string.Empty;
            bool isChange = false;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[0] == "Add")
                {
                    numbers.Add(comand[1]);
                    isChange = true;
                }
                else if (comand[0] == "Remove")
                {
                    numbers.Remove(comand[1]);
                    isChange = true;
                }
                else if (comand[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(comand[1]));
                    isChange = true;
                }
                else if (comand[0] == "Insert")
                {
                    numbers.Insert(int.Parse(comand[2]), comand[1]);
                    isChange = true;
                }
                else if (comand[0]=="Contains")
                {
                    if (numbers.Contains(comand[1]))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comand[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(numbers[i])%2==0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comand[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(numbers[i]) % 2 != 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comand[0] == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += int.Parse(numbers[i]);
                    }
                    Console.WriteLine(sum);
                }
                else if (comand[0] == "Filter")
                {
                    if (comand[1] == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(numbers[i]) < int.Parse(comand[2]))
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (comand[1] == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(numbers[i]) > int.Parse(comand[2]))
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (comand[1] == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(numbers[i]) >= int.Parse(comand[2]))
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (comand[1] == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(numbers[i]) <= int.Parse(comand[2]))
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

            }
            if (isChange)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
