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

/*       Console.WriteLine("Enter the number of Pastries you'd like to purchase: ");
      int PastryQuant = int.Parse(Console.ReadLine() ?? "0"); */

      Bread bread = new Bread();
      
      double BreadPrice = bread.CalculateTotalPrice(BreadQuant);
      double totalPrice = BreadPrice;
      Console.WriteLine($"Total Price: ${totalPrice}");
    }
  }
}

class Bread
{
  private const double BreadPrice = 5;

  public double CalculateTotalPrice(int quantity)
  {
    int paidBread = quantity / 3 * 2;
    int freeBread = quantity % 3;
    return (paidBread + freeBread) * BreadPrice;
  }
}
