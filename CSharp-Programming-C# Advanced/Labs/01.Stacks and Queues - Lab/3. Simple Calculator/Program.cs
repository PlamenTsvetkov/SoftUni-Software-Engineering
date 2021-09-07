using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Reverse()
              .ToList();
              
            var myStack = new Stack<string>(list);
            while (myStack.Count!=1)
            {
                int firstNum = int.Parse(myStack.Pop());
                char expresion = char.Parse(myStack.Pop());
                int secondNum = int.Parse(myStack.Pop());
                int result = 0;

                if (expresion=='+')
                {
                    result = firstNum + secondNum;
                }
                else if (expresion == '-')
                {
                    result = firstNum - secondNum;
                }
                myStack.Push(result.ToString());
            }

            Console.WriteLine(string.Join(" ",myStack));
        }
    }
}
