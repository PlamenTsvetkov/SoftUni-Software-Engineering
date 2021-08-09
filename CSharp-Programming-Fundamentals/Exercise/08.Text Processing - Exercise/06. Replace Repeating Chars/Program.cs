using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder stringText = new StringBuilder(text);
            for (int i = 0; i < stringText.Length-1; i++)
            {
                if (stringText[i]==stringText[i+1])
                {
                    stringText.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(stringText);
        }
    }
}
