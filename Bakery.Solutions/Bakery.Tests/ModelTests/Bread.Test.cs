using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests.Models.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_ShouldSetQuantity()
        {
            // Arrange
            int expectedQuantity = 5;

            // Act
            Bread bread = new Bread();
            bread.Quantity = expectedQuantity;

            // Assert
            Assert.AreEqual(expectedQuantity, bread.Quantity);
        }

        [TestMethod]
        public void CalculateTotalPrice_ShouldReturnNonDiscountPrice()
        {
            // Arrange
            int quantity = 2;
            double expectedPrice = 2 * Bread.BreadPrice;

            // Act
            Bread bread = new Bread();
            bread.Quantity = quantity;
            double totalPrice = bread.CalculateTotalPrice();

            // Assert
            Assert.AreEqual(expectedPrice, totalPrice);
        }

        [TestMethod]
        public void CalculateTotalPrice_ShouldReturnDiscountPrice()
        {
            // Arrange
            int quantity = 4;
            double expectedPrice = (2 * Bread.BreadPrice) + Bread.BreadPrice; // Buy 2, Get 1 Free

            // Act
            Bread bread = new Bread();
            bread.Quantity = quantity;
            double totalPrice = bread.CalculateTotalPrice();

            // Assert
            Assert.AreEqual(expectedPrice, totalPrice);
        }
    }
}
