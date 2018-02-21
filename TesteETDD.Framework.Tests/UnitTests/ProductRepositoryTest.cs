using System;
using TesteETDD.Framework.Repositories;
using TesteETDD.Framework.Repository.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteETDD.Framework.Tests.UnitTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        private ProductRepository _productRepository;

        [TestInitialize]
        public void Setup()
        {
            // TODO :: MOCK FOR UNIT TEST
        }

        [TestMethod]
        public void Test_Insert_New_Product()
        {
            var product = new Product();
            product.Name = "Nome do produto";
            product.Description = "Descrição do produto";
            product.Status = true;

            var newProduct = _productRepository.Insert(product);

            Assert.IsTrue(Guid.TryParse(product.ProductId.ToString(), out _));
        }
    }
}
