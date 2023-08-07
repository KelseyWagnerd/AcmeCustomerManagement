using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveCustomerTest()

        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "s.squarepants@krustykrab.kom",
                FirstName = "SpongeBob",
                LastName = "SquarePants",
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
               Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }

        /*

        [TestMethod]

        public void RetrieveExistingWithAddress()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "s.squarepants@krustykrab.kom",
                FirstName = "SpongeBob",
                LastName = "SquarePants",
                AddressList = new List<Address>()
                {
                      new Address(1)
                     {
                       AddressType = 1,
                      Street1 = "Rock Bottom Road",
                       City = "Bikini Bottom",
                       State = "Bikini Atoll",
                       Country = "USA",
                      PostalCode = "666"
                       },

                     new Address(2)
                      {
                      AddressType = 2,
                      Street1 = "Creepy Street",
                      City = "Rock Bottom",
                      State = "Bikini Atoll",
                      Country = "USA",
                      PostalCode = "666"
                     }
                }
            };

            // Act
            var actual = customerRepository.Retrieve(1);


            // Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].Street1, actual.AddressList[i].Street1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        } */

        }
    }

