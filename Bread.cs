using System;

namespace app
{
  class BakeryBread
  {
    public const double BreadPrice = 5;

    public double CalculateTotalPrice(int quantity)
    {
      int paidBread = quantity / 3 * 2;
      int freeBread = quantity % 3;
      return (paidBread + freeBread) * BreadPrice;
    }
  }
}