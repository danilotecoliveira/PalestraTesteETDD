using System;
using TesteETDD.Framework.Repositories;
using TesteETDD.Framework.Repository.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteETDD.Framework.Tests.IntegrationTests
{
    [TestClass]
    public class ProductRepositoryTI
    {
        private ProductRepository _productRepository;

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
