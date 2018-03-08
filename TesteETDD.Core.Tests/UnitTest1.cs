using System;
using TesteETDD.Core.Web.Models;
using TesteETDD.Core.Web.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteETDD.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Products _products = new Products();

        [TestMethod]
        public void TestMethod1()
        {
            var product = new Product
            {
                Name = ""
            };

            var result = _products.Insert(product);

            Assert.IsTrue(Guid.TryParse(result.ToString(), out _));
        }
    }
}
