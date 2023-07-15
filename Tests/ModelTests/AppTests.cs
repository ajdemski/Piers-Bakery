using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace app
{
  [TestClass]
  public class AppTests
  {
    [TestMethod]
    public void TestCalculateTotalBreadPrice()
    {
      //Arange
      BakeryBread bread = new BakeryBread();
      int BreadQuantity = 5;
      double expectedBreadPrice = 15;

      //Act
      double actualBreadPrice = bread.CalculateTotalPrice(BreadQuantity);

      //Assert
      Assert.AreEqual(expectedBreadPrice, actualBreadPrice);
    }
    
    [TestMethod]
    public void TestCalculateTotalPastryPrice()
    {
      // test logic 
    }

  }
}