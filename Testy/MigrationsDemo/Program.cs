using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using MigrationsDemo.Migrations;

namespace MigrationsDemo
{

   class Program
   {
      static void Main(string[] args) {
         //Automatically Upgrading on Application Startup (MigrateDatabaseToLatestVersion Initializer)
         Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>()); 

         using (var db = new BlogContext()) {
            //db.Blogs.Add(new Blog { Name = "Another Blog " });
            //db.SaveChanges();

            foreach (var blog in db.Blogs) {
               Console.WriteLine(blog.Name);
            }
         }

         Console.WriteLine("Press any key to exit...");
         Console.ReadKey();
      }
   }
}




