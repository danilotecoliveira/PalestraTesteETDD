using System.Data.Entity;

namespace TesteETDD.FW.Web.Models
{
    public class Context : DbContext
    {
        public Context() : base("Server=tcp:fiap11net.database.windows.net,1433;Initial Catalog=testeetdd;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}