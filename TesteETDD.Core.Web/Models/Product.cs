using System;

namespace TesteETDD.Core.Web.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsValid(Product product)
        {
            //return (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Description));

            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("O nome do produto é obrigatório");

            if (string.IsNullOrWhiteSpace(Description))
                throw new Exception("A descrição do produto é obrigatória");

            return true;
        }
    }
}
