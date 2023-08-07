using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace ACM.BLTest
{
    [TestClass()]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()

        {
            // Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "HydroDynamic Spatula",
                ProductDescription = "With port and starboard attachments, and turbo drive.",
                CurrentPrice = 2999.99M,
            };

            // Act
            var actual = productRepository.Retrieve(1);

            // Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
