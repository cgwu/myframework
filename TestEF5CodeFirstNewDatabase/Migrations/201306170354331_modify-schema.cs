namespace TestEF5CodeFirstNewDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyschema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        nick_name = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
            AddColumn("dbo.Blogs", "URL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "URL");
            DropTable("dbo.Users");
        }
    }
}
