using System;
using TesteETDD.Core.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteETDD.Core.Tests.UnitTests
{
    [TestClass]
    public class ProductUnitTest
    {
        [TestMethod]
        public void Check_If_Product_Is_Valid()
        {
            var product = new Product
            {
                Name = "Nome do produto",
                Description = "Descrição do produto"
            };

            var result = product.IsValid(product);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Check_If_Validation_Works_For_Name()
        {
            var product = new Product
            {
                Name = "",
                Description = "Descrição do produto"
            };

            product.IsValid(product);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Check_If_Validation_Works_For_Description()
        {
            try
            {
                var product = new Product
                {
                    Name = "Nome do produto",
                    Description = ""
                };

                var result = product.IsValid(product);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("A descrição do produto é obrigatória", ex.Message);
                throw;
            }
        }
    }
}
