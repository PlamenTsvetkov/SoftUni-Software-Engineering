using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> currentItem = input //: {Serial Number} {Item Name} {Item Quantity} {itemPrice}
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                double priceForBox = double.Parse(currentItem[2]) * double.Parse(currentItem[3]);
                Box box = new Box(currentItem[0], currentItem[1], int.Parse(currentItem[2]), double.Parse(currentItem[3]), priceForBox);
                boxes.Add(box);

            }
            Console.WriteLine(string.Join(Environment.NewLine,boxes.OrderByDescending(x=>x.PriceForBox)));

        }
        public class Box
        {
            public double Price { get; set; }
            
            public string SerialNumber { get; set; }
            public string Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForBox { get; set; }
            public Box( string serialNumber, string item, int itemQuantity, double price, double priceForBox)
            {
                
                this.SerialNumber = serialNumber;
                this.Item = item;
                this.ItemQuantity = itemQuantity;
                this.Price = price;
                this.PriceForBox = priceForBox;

            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(SerialNumber);
                sb.AppendLine($"-- {Item} - ${Price:f2}: {ItemQuantity}");
                sb.AppendLine($"-- ${PriceForBox:F2}");
                return sb.ToString().TrimEnd(); 
            }

        }
    }
}
