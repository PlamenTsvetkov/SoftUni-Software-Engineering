using System;
using System.Text;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char cha1 = char.Parse(Console.ReadLine());
            char cha2 = char.Parse(Console.ReadLine());
            PrintCharacterBetweenTwoChar(cha1,cha2);
        }

         static void PrintCharacterBetweenTwoChar(char cha1, char cha2)
        {
            if (cha1<cha2)
            {
                for (int i = cha1 + 1; i < cha2; i++)
                {
                    Console.Write(($"{(char)i} "));
                }
            }
            else
            {
                for (int i = cha2 + 1; i < cha1; i++)
                {
                    Console.Write(($"{(char)i} "));
                }
            }
           
            
        }
    }
}
