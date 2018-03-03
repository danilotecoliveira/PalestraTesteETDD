using System;
using System.Data.SqlClient;

namespace TesteETDD.FW.Web.Repositories
{
    public interface IDao<T>
    {
        Guid Insert(T elemento);
    }
}