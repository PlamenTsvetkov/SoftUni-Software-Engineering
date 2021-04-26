using System;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantSm = double.Parse(Console.ReadLine());
            double smLetva = wantSm-30;
            double jump = 0;
            int unsussesful = 0;
            bool isValid = false;
            int jumpNum = 0;
            while (smLetva<=wantSm)
            {
                jump = double.Parse(Console.ReadLine());
                jumpNum += 1;
                if (jump>smLetva)
                {
                    unsussesful = 0;
                    smLetva += 5;
                }
                else if (jump<=smLetva)
                {
                    unsussesful += 1;
                }
                if (unsussesful==3)
                {
                    isValid = true;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine($"Tihomir failed at {smLetva}cm after {jumpNum} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {wantSm}cm after {jumpNum} jumps.");
            }
        }
    }
}
