using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void PRetrieveValid()
        {
            //--Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName ="SunFlowers",
                ProductDescription = "This is a product",
                CurrentPrice = 15.56M
            };

            //--Act
            var actual = productRepository.Retrieve(2);

            //--Assert

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
