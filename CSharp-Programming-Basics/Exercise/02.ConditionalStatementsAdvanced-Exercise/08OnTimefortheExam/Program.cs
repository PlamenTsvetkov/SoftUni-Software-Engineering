using System;

namespace _08OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExame = int.Parse(Console.ReadLine());
            int minutExame = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int razlika = (hourArrive * 60 + minuteArrive) - (hourExame * 60 + minutExame);
//zakysnql
            if (razlika>0)
            {
                Console.WriteLine("Late");
                if (razlika <60)
                {
                    Console.WriteLine($"{razlika} minutes after the start");
                }
                else if (razlika >=60)
                {
                    Console.WriteLine($"{razlika/60}:{razlika % 60:D2} hours after the start");
                }
                    
            }
            else if (0>=razlika && razlika >=-30)
            {
                Console.WriteLine("On time");
            }
                if (razlika >= -30)
                {
                Console.WriteLine($"{Math.Abs(razlika)} minutes before the start");
                }
            else if (razlika < -30)
            {
                Console.WriteLine("Early");
            }
            if (razlika > -60)
            {
                Console.WriteLine($"{Math.Abs(razlika)} minutes before the start");
            }
            else if (razlika <= -60)
            {
                Console.WriteLine($"{Math.Abs(razlika) / 60}:{Math.Abs(razlika) % 60:D2} hours before the start");
            }
        }
    }
}
