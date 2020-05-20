using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerrepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {

            //-- Arrange 

            var customerRepository = new CustomerReposityory();

            var expected = new Customer(1)
            {
                //CustomerId = 1,// CustoemrId has private set so we use constructor
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"

            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual); // AreEqual objelerin referans typearını kontrol ediyor, dolayısıyla 2 objenin referans type 'ı farklı biri CustomerRepository classından diğer Customer classından üretilmiş.
            // Dolayısıyla bu kodun yerine özelliklerin tek tek kontrolünü gerçekleştiriyıruz.
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //--Arrange
            var customerRepo = new  CustomerReposityory();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins.hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                       AddressType = 1,
                       StreetLine1 = "Bag End",
                       StreetLine2 = "Bagshot row",
                       City = "Hobbiton",
                       State = "Shire",
                       Country = "Middle Earth",
                       PostCode = "144"

                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostCode = "146"
                    }

                }

            };

            //--Act
            var actual = customerRepo.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].PostCode, actual.AddressList[i].PostCode);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);

            }


        }
    }
}
