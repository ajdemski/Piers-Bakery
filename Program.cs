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
      int BreadQuant = int.Parse(Console.ReadLine() ?? "0");
      Console.WriteLine("Enter the number of Pastries you'd like to purchase: ");
      int PastryQuant = int.Parse(Console.ReadLine() ?? "0");

      BakeryBread bread = new BakeryBread();
      Pastry pastry = new Pastry();

      double breadPrice = bread.CalculateTotalPrice(BreadQuant);
      double pastryPrice = pastry.CalculateTotalPrice(PastryQuant);

      double totalPrice = breadPrice + pastryPrice;
      Console.WriteLine($"Total Price: ${totalPrice}");
      Console.ReadLine();
    }
  }

  class Pastry
  {
    private const double PastryPrice = 2;

    public double CalculateTotalPrice(int quantity)
    {
      int paidPastries = quantity / 4 * 3;
      int freePastries = quantity % 4;
      return (paidPastries + freePastries) * PastryPrice;
    }
  }
}