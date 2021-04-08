using System;

namespace _06specialNumbers
{
    class specialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ifTrue = 0;
            for (int i = 1111; i <= 9999; i++)
            {
                int numi = i;
                for (int j = 1; j <= 4; j++)
                {
                    if (numi % 10 == 0)
                    {
                        break;
                    }
                    if (n % (numi % 10) == 0)
                    {
                        ifTrue += 1;
                    }
                    numi = numi / 10;
                    
                }
                if (ifTrue == 4)
                {
                    Console.Write($"{i} ");
                }
                ifTrue = 0;

            }

        }
    }
}
