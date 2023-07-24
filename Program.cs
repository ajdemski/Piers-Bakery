using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread: $5 each or buy 2, get 1 free");
            Console.WriteLine("Pastry: $2 each or buy 3, get 1 free");

            Console.WriteLine("Enter the number of Bread you'd like to purchase: ");
            int breadQuant = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter the number of Pastries you'd like to purchase: ");
            int pastryQuant = int.Parse(Console.ReadLine() ?? "0");

            Bread bread = new Bread { Quantity = breadQuant };
            Pastry pastry = new Pastry { Quantity = pastryQuant };

            double breadPrice = bread.CalculateTotalPrice();
            double pastryPrice = pastry.CalculateTotalPrice();

            double totalPrice = breadPrice + pastryPrice;
            Console.WriteLine($"Total Price: ${totalPrice}");
            Console.ReadLine();
        }
    }
}
