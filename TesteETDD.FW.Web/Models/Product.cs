using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteETDD.FW.Web.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }

        public Product Save(Product product)
        {
            return null;
        }
    }
}