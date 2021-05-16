using System;

namespace _01
{
    class roomPainting
    {
        static void Main(string[] args)
        {
            double paintQuantity = double.Parse(Console.ReadLine());
            double wallpaperQuantity = double.Parse(Console.ReadLine());
            double glovesPrice = double.Parse(Console.ReadLine());
            double paintbrushPrice = double.Parse(Console.ReadLine());


            double paintPrice = 21.50;
            double wallpaperPrice = 5.20;
            double glovesQuantity = Math.Ceiling(wallpaperQuantity * 0.35);
            double paintbrushQuantity = Math.Floor(paintQuantity * 0.48);

            double totalPaintPrice = paintQuantity * paintPrice;
            double totalWallpaperPrice = wallpaperQuantity*wallpaperPrice;
            double totalGlovesPrice = glovesQuantity*glovesPrice;
            double totalBrushPrice = paintbrushQuantity*paintbrushPrice;

            double totalDelivery = totalPaintPrice + totalWallpaperPrice + totalGlovesPrice + totalBrushPrice;
            double deliveryPrice = totalDelivery * 1 / 15;
            Console.WriteLine($"This delivery will cost {deliveryPrice:F2} lv.");


        }
    }
}
