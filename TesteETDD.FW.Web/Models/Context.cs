using System.Data.Entity;

namespace TesteETDD.FW.Web.Models
{
    public class Context : DbContext
    {
        public Context() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\PalestraTesteETDD\DB\dbtestetdd.mdf;Integrated Security=True;Connect Timeout=30")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}