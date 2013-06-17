using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TestEF5CodeFirstExistingDatabase.Models.Mapping;

namespace TestEF5CodeFirstExistingDatabase.Models
{
    public partial class TestEF5Context : DbContext
    {
        static TestEF5Context()
        {
            Database.SetInitializer<TestEF5Context>(null);
        }

        public TestEF5Context()
            : base("Name=TestEF5Context")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new PostMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
