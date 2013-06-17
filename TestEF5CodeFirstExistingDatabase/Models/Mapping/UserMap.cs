using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TestEF5CodeFirstExistingDatabase.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Name);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.nick_name).HasColumnName("nick_name");
        }
    }
}
