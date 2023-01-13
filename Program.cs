using System;

namespace Food_delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pileshkoMenu = double.Parse(Console.ReadLine()) * 10.35;
            double ribaMenu = double.Parse(Console.ReadLine()) * 12.40;
            double vegeMenu = double.Parse(Console.ReadLine()) * 8.15;

            double totalMenus = (pileshkoMenu + ribaMenu + vegeMenu);
            double totalWithDiscount = totalMenus * 0.20;
            double totalPrice = totalMenus + totalWithDiscount + 2.50;

            Console.WriteLine(totalPrice);
        }
    }
}
