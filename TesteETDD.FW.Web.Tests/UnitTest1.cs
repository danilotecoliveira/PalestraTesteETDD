using System;
using TesteETDD.FW.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteETDD.FW.Web.Repositories;

namespace TesteETDD.FW.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Product _product = new Product();
        private Products _products = new Products();

        [TestMethod]
        public void Insert_Product_With_Success()
        {
            var product = new Product
            {
                Name = "Nome do Produto",
                Description = "Descrição do Produto"
            };

            var result = _products.Insert(product);

            Assert.IsTrue(Guid.TryParse(result.ToString(), out _));
            Assert.AreNotEqual(result, Guid.Empty);
        }
    }
}