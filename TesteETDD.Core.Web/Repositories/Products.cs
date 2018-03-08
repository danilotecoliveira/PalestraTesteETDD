using System;
using System.Data.SqlClient;
using TesteETDD.Core.Web.Models;
using System.Collections.Generic;
using TesteETDD.Core.Web.Repositories.Interfaces;

namespace TesteETDD.Core.Web.Repositories
{
    public class Products : IRepository<Product>
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        //private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30";
        private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danilo.t0458\Git\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30";

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Insert(Product product)
        {
            try
            {
                product.ProductId = Guid.NewGuid();

                using (conn = new SqlConnection(strConexao))
                {
                    using (cmd = new SqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @"insert into Products (ProductId, Name, Description) values (@ProductId, @name, @Description)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@Description", product.Description);
                        reader = cmd.ExecuteReader();
                    }
                }

                return product.ProductId;
            }
            catch
            {
                return Guid.Empty;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
