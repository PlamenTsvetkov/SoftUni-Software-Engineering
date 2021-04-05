using System;

namespace _01NumberPyramid
{
    class numberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int i = 1; i <=n; i++)
            {
                for (int colm = 0; colm < i; colm++)
                {
                    if (current>n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current+" ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
