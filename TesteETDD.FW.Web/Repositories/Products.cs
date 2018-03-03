using System;
using System.Data.SqlClient;
using TesteETDD.FW.Web.Models;

namespace TesteETDD.FW.Web.Repositories
{
    public class Products : IDao<Product>
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30";

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
    }
}