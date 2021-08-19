using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            if (lectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }
            int initialBonus = int.Parse(Console.ReadLine());
            double maxBonus = int.MinValue;
            double maxAttendance = int.MinValue;
            for (int i = 0; i < students; i++)
            {
                double currentStudentsAttendance = double.Parse(Console.ReadLine());
                double currentTotalBonus = currentStudentsAttendance / lectures * (5 + initialBonus);
                currentTotalBonus = Math.Ceiling(currentTotalBonus);
                if (currentTotalBonus>=maxBonus)
                {
                    maxBonus = currentTotalBonus;
                    maxAttendance = currentStudentsAttendance;
                }

            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
