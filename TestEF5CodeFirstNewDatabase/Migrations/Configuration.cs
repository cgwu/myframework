namespace TestEF5CodeFirstNewDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestEF5CodeFirstNewDatabase.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestEF5CodeFirstNewDatabase.BlogContext context)
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

            context.Blogs.AddOrUpdate(
                p => p.Name,
                new Blog { Name = "��һƪ,�ҵĲ��Ϳ�ͨ��" },
                new Blog { Name = "�ڶ�ƪ" },
                new Blog { Name = "����ƪ" }
                );

        }
    }
}
