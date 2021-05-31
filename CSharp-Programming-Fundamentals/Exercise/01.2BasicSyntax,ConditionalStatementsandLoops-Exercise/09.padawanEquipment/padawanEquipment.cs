using System;

namespace _09.padawanEquipment
{
    class padawanEquipment
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabresQuantity = Math.Ceiling(countStudents * 1.1);
            double robesQuantity = countStudents;
            double beltsQuantity = countStudents- (countStudents/6);

            double totalExpenses = lightsabersPrice * lightsabresQuantity + robesPrice * robesQuantity + beltsPrice * beltsQuantity;
            if (totalExpenses<=amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalExpenses-amountMoney:f2}lv more.");
            }
        }
    }
}
