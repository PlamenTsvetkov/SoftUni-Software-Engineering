using System;

namespace _04NakovSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля въведете брой числа н = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете {0} числа едно след друго, всяко на отделен ред", n);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("num {0} = " , i);
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Сумате е " + sum);
        }
    }
}
