using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests.Models.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_ShouldSetQuantity()
        {
            // Arrange
            int expectedQuantity = 3;

            // Act
            Pastry pastry = new Pastry();
            pastry.Quantity = expectedQuantity;

            // Assert
            Assert.AreEqual(expectedQuantity, pastry.Quantity);
        }

        [TestMethod]
        public void CalculateTotalPrice_ShouldReturnNonDiscountPrice()
        {
            // Arrange
            int quantity = 2;
            double expectedPrice = 2 * Pastry.PastryPrice;

            // Act
            Pastry pastry = new Pastry();
            pastry.Quantity = quantity;
            double totalPrice = pastry.CalculateTotalPrice();

            // Assert
            Assert.AreEqual(expectedPrice, totalPrice);
        }

        [TestMethod]
        public void CalculateTotalPrice_ShouldReturnDiscountPrice()
        {
            // Arrange
            int quantity = 7;
            double expectedPrice = (5 * Pastry.PastryPrice) + Pastry.PastryPrice;

            // Act
            Pastry pastry = new Pastry();
            pastry.Quantity = quantity;
            double totalPrice = pastry.CalculateTotalPrice();

            // Assert
            Assert.AreEqual(expectedPrice, totalPrice);
        }
    }
}