using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange

            var source = "HydroDynamicSpatula";
            var expected = "Hydro Dynamic Spatula";

            //  Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Hydro Dynamic Spatula";
            var expected = "Hydro Dynamic Spatula";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
