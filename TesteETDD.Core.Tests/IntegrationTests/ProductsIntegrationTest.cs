using System;
using System.Linq;
using TesteETDD.Core.Web.Models;
using TesteETDD.Core.Web.Repositories;
using TesteETDD.Core.Web.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteETDD.Core.Tests
{
    [TestClass]
    public class ProductsIntegrationTest
    {
        private IProducts _products;

        public ProductsIntegrationTest()
        {
            _products = new Products();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var product = new Product
            {
                Name = "Produto teste",
                Description = "Descrição do produto teste"
            };

            var result = _products.Insert(product);

            Assert.IsTrue(Guid.TryParse(result.ToString(), out _));
            Assert.AreNotEqual(result, Guid.Empty);
        }

        [TestCleanup]
        public void Clear_Tests()
        {
            var list = _products.GetAll();

            foreach (var item in list)
            {
                _products.Delete(item.ProductId);
            }

            var newList = _products.GetAll();

            Assert.IsTrue(list.ToList().Count > 0);
            Assert.IsTrue(newList.ToList().Count == 0);
            Assert.AreNotEqual(list, newList);
        }
    }
}
