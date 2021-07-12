using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lists = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (comand[0]=="Add")
                {
                    lists.Add(int.Parse(comand[1]));
                }
                else if (comand[0] == "Insert")
                {
                    if (int.Parse(comand[2]) >= lists.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        lists.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                    }                    
                }
                else if (comand[0] == "Remove")
                {
                    if (int.Parse(comand[1]) >= lists.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        lists.RemoveAt(int.Parse(comand[1]));
                    }
                }
                else if (comand[0] == "Shift")
                {
                    if (comand[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(comand[2]); i++)
                        {
                            int firstNumber = lists[0];
                            for (int j = 0; j < lists.Count-1; j++)
                            {
                                
                                lists[j] = lists[j + 1];
                                
                            }
                            lists[lists.Count - 1] = firstNumber;

                        }
                    }
                    else if  (comand[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(comand[2]); i++)
                            {
                                int lastNumber = lists[lists.Count-1];
                                for (int j = lists.Count - 1; j >0; j--)
                                {

                                    lists[j] = lists[j - 1];

                                }
                                lists[0] = lastNumber;

                            }
                        }
                }



            }
            Console.WriteLine(string.Join(" ", lists));
        }

        
    }
}
