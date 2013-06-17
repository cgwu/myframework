using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestEF5CodeFirstExistingDatabase.Models;

namespace TestEF5CodeFirstExistingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestEF5Context())
            {
                db.Users.Add(new User() { Name = "cuteCC", nick_name = "可爱CC" });
                db.SaveChanges();
            }

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
