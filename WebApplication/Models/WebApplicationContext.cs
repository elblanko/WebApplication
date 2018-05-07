using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication.Models
{
    public class WebApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
                                         //name=Nombre que tiene el contexto en web.config
        public WebApplicationContext() : base("name=WebApplicationContext")
        {
        }

        //Deshabilita borrado en cascada
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //Se crea contexto por cada tabla creada
        public System.Data.Entity.DbSet<WebApplication.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Customer> Customers { get; set; }
    }
}
