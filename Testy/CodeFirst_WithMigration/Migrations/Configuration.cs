namespace CodeFirst_WithMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_WithMigration.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst_WithMigration.TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
					context.Students.AddOrUpdate(
						p => p.Name,
						new Student { Name = "Andrew", Surname= "Peters" },
						new Student { Name = "Brice", Surname = "Lambson" },
						new Student { Name = "Rowan", Surname = "Miller" }
					);
					context.SaveChanges();

				}
    }
}
