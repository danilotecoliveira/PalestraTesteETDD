using System;
using System.Linq;

namespace TesteETDD.FW.Web.Models
{
    public class Product
    {
        public Guid ProductId { get; private set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get { return DateTime.Now; } }

        private Context _context;

        public Product()
        {
            _context = new Context();
        }

        public Product Save(Product product)
        {
            product.ProductId = Guid.NewGuid();
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public Product GetById(Guid productId)
        {
            return _context.Products.FirstOrDefault(m => m.ProductId == productId);
        }

        // TODO :: METHOD FOR GET ALL
    }
}