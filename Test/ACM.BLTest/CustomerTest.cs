using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace ACM.BLTest
{
    [TestClass]
    // Don't forget to add references by right clicking References and adding ACM.BL
    public class CustomerTest
    {

        [TestMethod]

        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Dunderhead",
                EmailAddress = "its@me.com"
            };
            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            { 
            EmailAddress = "tim@myspace.com"
            };
            var expected = false;

            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        { //Arrange
            var c1 = new Customer();
            c1.FirstName = "Billy Bob";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Fitzgerald";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Wilhelmina";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

         [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer testCustomer = new Customer
            {
                FirstName = "SpongeBob",
                LastName = "SquarePants"
            };

            string expected = "SquarePants, SpongeBob";

            // Act
            string actual = testCustomer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        } 
    }
}
