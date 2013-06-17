using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TestEF5CodeFirstExistingDatabase.Models.Mapping
{
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            // Primary Key
            this.HasKey(t => t.BlogId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Blogs");
            this.Property(t => t.BlogId).HasColumnName("BlogId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.URL).HasColumnName("URL");
        }
    }
}
