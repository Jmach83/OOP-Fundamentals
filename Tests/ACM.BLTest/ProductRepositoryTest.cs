using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "SunFlowers Description",
                ProductName = "SunFlowers"
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updateProduct);

            Assert.AreEqual(true, actual);
        }

        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            var actual = productRepository.Save(updateProduct);

            Assert.AreEqual(false, actual);
        }
    }
}
