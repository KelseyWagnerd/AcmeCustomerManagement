using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderTest()

        {
            // Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(000)
            {
                ShippingAddress = "Yo Mama's House"
        };

            // Act
            var actual = orderRepository.Retrieve(000);

            // Assert
            Assert.AreEqual(expected.ShippingAddress, actual.ShippingAddress);
        }
    }
}
