using System;
using System.Numerics;

namespace _11.snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            BigInteger hightestValue = 0;
            int hightestsnowballSnow = 0;
            int hightestsnowballTime = 0;
            int hightestsnowballQuality = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > hightestValue)
                {
                    hightestValue = snowballValue;
                    hightestsnowballSnow = snowballSnow;
                    hightestsnowballTime = snowballTime;
                    hightestsnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{hightestsnowballSnow} : {hightestsnowballTime} = {hightestValue} ({hightestsnowballQuality})");
            
        }
    }

    
}
