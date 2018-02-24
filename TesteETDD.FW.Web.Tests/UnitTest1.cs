using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteETDD.FW.Web.Models;

namespace TesteETDD.FW.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Product _product = new Product();

        [TestMethod]
        public void Insert_Product_With_Success()
        {
            var product = new Product
            {
                Name = "Nome do Produto"
            };

            var result = _product.Save(product);

            Assert.IsTrue(Guid.TryParse(result.ProductId.ToString(), out _));
        }
    }
}
