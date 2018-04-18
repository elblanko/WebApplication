namespace WebApplication.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication.Models.WebApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //Permitir truncar datos
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = "WebApplication.Models.WebApplicationContext";
        }

        protected override void Seed(WebApplication.Models.WebApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
