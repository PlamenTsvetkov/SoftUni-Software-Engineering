using System;

namespace _04.AnaSumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool magicNumberFound = false;

            int combination = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int j = start; j <= finish; j++)
                {
                    combination++;
                    int result = i + j;
                    if (result==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        magicNumberFound = true;
                        break;
                    }
                }
                if (magicNumberFound)
                {
                    break;
                }
            }
            if (!magicNumberFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals { magicNumber }");
            }            
        }
    }
}
