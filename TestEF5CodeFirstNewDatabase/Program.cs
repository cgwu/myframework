using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TestEF5CodeFirstNewDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the name of a new blog:");
            string title = Console.ReadLine();
            var blog = new Blog() { Name = title };

            using (var db = new BlogContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
            */
            /*
            Console.WriteLine("正在重建数据库");
            using (var db = new BlogContext())
            {
                db.Database.Delete();
                //db.Database.Create();
                //or
                //db.Database.CreateIfNotExists();
            }*/
            Console.WriteLine("完成!");
            Console.ReadKey();
        }
    }


    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class User
    {
        [Key]
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }


    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection") { }
        public BlogContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("nick_name");


            modelBuilder.Entity<Blog>()
                .Property(e => e.Url)
                .HasColumnName("URL");

            /*
            modelBuilder.Entity<Blog>()
                .ToTable("t_blog");
             */
        }
    }
}
