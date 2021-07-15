using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {

        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split().ToArray();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int timelyPoin = rnd.Next(0, text.Length);
                string currentPoint = text[i];
                text[i] = text[timelyPoin];
                text[timelyPoin] = currentPoint;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine,text));
        }

    }
}
