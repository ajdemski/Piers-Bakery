using System;

namespace Bakery
{
    public class Bread
    {
        public const double BreadPrice = 5;

        public int Quantity { get; set; }

        public double CalculateTotalPrice()
        {
            int paidBread = Quantity / 3 * 2;
            int freeBread = Quantity % 3;
            return (paidBread + freeBread) * BreadPrice;
        }
    }
}
