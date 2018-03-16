using System;
using System.Data.SqlClient;
using TesteETDD.Core.Web.Models;
using System.Collections.Generic;
using TesteETDD.Core.Web.Repositories.Interfaces;

namespace TesteETDD.Core.Web.Repositories
{
    public class Products : IProducts
    {
        private SqlConnection conn;
        //private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30";
        private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danilo.t0458\Git\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30";

        public IEnumerable<Product> GetAll()
        {
            try
            {
                var list = new List<Product>();

                using (conn = new SqlConnection(strConexao))
                {
                    using (var cmd = new SqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @"select * from Products where Name like 'teste'";

                        list = Mapper(cmd.ExecuteReader());
                    }
                }

                return list;
            }
            catch
            {
                return null;
            }
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
                    using (var cmd = new SqlCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @"insert into Products (ProductId, Name, Description) values (@ProductId, @name, @Description)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                        cmd.Parameters.AddWithValue("@Name", product.Name);
                        cmd.Parameters.AddWithValue("@Description", product.Description);
                        cmd.ExecuteNonQuery();
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

        private List<Product> Mapper(SqlDataReader reader)
        {
            var list = new List<Product>();

            while (reader.Read())
            {
                list.Add(
                    new Product
                    {
                        ProductId = Guid.Parse(reader["ProductId"].ToString()),
                        Name = reader["Name"].ToString(),
                        Description = reader["Description"].ToString()
                    });
            }

            return list;
        }
    }
}
