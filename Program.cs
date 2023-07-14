using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread: $5 each or buy 2, get 1 free");
            Console.WriteLine("Pastry: $2 each or buy 3, get 1 free");

            Console.WriteLine("Enter the number of Bread you'd like to purchase: ");
            int Bread = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of Pastries you'd like to purchase: ");
            int Pastry = int.Parse(Console.ReadLine());
        }
    }
}