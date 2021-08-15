using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {

            byte firstEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte secondEmployeeEfficiency = byte.Parse(Console.ReadLine());
            byte thirdEmployeeEfficiency = byte.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int totalStudentsForHour = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            int timeNeeded = 0;
            while (studentsCount>0)
            {
                timeNeeded++;
                studentsCount -= totalStudentsForHour;
                if (timeNeeded%4==0)
                {
                    timeNeeded++;
                }
            }
             
            

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
