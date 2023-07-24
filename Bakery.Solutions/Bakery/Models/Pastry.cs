using System;

namespace Bakery
{
    public class Pastry
    {
        // Add the PastryPrice constant
        public const double PastryPrice = 2;

        // Auto-implemented property for Quantity
        public int Quantity { get; set; }

        // Method to calculate the total price for pastries
        public double CalculateTotalPrice()
        {
            int paidPastries = Quantity / 4 * 3;
            int freePastries = Quantity % 4;
            return (paidPastries + freePastries) * PastryPrice;
        }
    }
}
