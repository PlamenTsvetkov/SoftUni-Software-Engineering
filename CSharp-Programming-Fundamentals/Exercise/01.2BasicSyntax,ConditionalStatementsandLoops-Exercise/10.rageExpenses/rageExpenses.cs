using System;

namespace _10.rageExpenses
{
    class rageExpenses
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetQuantity = lostGame / 2;
            int mouseQuantity = lostGame / 3;
            int keyboardQuantity = lostGame/6;
            int displayQuantity=keyboardQuantity/2;
           
            double totalExpenses = headsetPrice * headsetQuantity + mousePrice * mouseQuantity + keyboardPrice * keyboardQuantity + displayPrice * displayQuantity;
           Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
