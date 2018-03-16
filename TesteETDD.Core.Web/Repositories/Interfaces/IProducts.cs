using System;
using TesteETDD.Core.Web.Models;
using System.Collections.Generic;

namespace TesteETDD.Core.Web.Repositories.Interfaces
{
    public interface IProducts
    {
        IEnumerable<Product> GetAll();
        Product Get(Guid id);
        Guid Insert(Product product);
        void Delete(Guid id);
        bool SendProduct(Product product);
    }
}
