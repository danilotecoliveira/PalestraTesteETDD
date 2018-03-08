using System;
using System.Collections.Generic;

namespace TesteETDD.Core.Web.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        Guid Insert(T elemento);
        void Delete(Guid id);
    }
}
