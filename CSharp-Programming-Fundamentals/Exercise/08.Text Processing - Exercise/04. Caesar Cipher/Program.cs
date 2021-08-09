using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder changeText = new StringBuilder(text);
            
            for (int i = 0; i < changeText.Length; i++)
            {
                char currentSimvol = text[i];
                currentSimvol += (char)3;
                changeText[i] = currentSimvol;
            }
            Console.WriteLine(changeText);
        }
    }
}
