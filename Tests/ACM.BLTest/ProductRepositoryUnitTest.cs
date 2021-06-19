using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryUnitTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sunflower",
                ProductDescription = "Assorted size set of 4 bright yellow mini sunflower",
                CurrentPrice = 15.96
            };

            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod()]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
