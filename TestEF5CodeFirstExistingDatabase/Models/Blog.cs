using System;
using System.Collections.Generic;

namespace TestEF5CodeFirstExistingDatabase.Models
{
    public partial class Blog
    {
        public Blog()
        {
            this.Posts = new List<Post>();
        }

        public int BlogId { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
