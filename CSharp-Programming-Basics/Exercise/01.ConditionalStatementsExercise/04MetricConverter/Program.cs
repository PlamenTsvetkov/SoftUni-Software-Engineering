using System;
using System.Text;

namespace _04MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string meInput = Console.ReadLine();
            string meOutput = Console.ReadLine();

            double m = 1;
            double mm = 1000;
            double cm = 100;


            if (meInput == "mm")
            {
                a = a / mm ;
            }
            else if (meInput == "cm")
            {
                a = a / cm;
            }
            else if (meInput == "m")
            {
                a = a / m;
            }
            if (meOutput == "mm" )
            {
                a = a * mm;
            }
            else if (meOutput =="cm")
            {
                a = a * cm;
            }
            else if (meOutput == "m")
            {
                a = a * m;
            }

            Console.WriteLine($"{a:F3}");
        }
    }
}
