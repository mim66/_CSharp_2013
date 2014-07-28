using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace MigrationsDemo
{
   // właczenie opcji migracji dla CodeFirst
   // Enable-Migrations

   // a następnie po każdej zmianie struktury dodaj zmianę i zaktualizuj ją na serwerze Sql Server
   // Add-Migration 'nazwa zmiany'  
   // Update-Database

   // przykład: u mnie po dodaniu  'public string Url { get; set; }'  do klasy Blog wykonuję te komendy w Package Manager Console 
   // Add-Migration AddBlogUrl
   // Update-Database

   // Jeżeli potrzebujemy jeszcze coś zmienić np w pliku 201407250711123_AddPostClass.cs to później koniecznie trzeba wykonać
   // Update-Database –Verbose

   // Migrate to a Specific Version (Including Downgrade)
   // This command will run the Down script for our AddBlogAbstract and AddPostClass migrations.
   // Update-Database –TargetMigration: AddBlogUrl

   // generuj skrypty Sql-owe od bieżącej wersji do ostatniej
   // Update-Database -Script

   // Przywrócenie bazy do stanu początkowego
   // Update-Database –TargetMigration: $InitialDatabase

   // Automatically Upgrading on Application Startup (MigrateDatabaseToLatestVersion Initializer)
   // add to Main(string[] args)
   // Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>()); 
   
   public class BlogContext : DbContext
   {
      public DbSet<Blog> Blogs { get; set; }
   }

   public class Blog
   {
      public int BlogId { get; set; }
      public string Name { get; set; }
      public string Url { get; set; }
      public int Rating { get; set; }

      public virtual List<Post> Posts { get; set; }
   }

   public class Post 
   { 
         public int PostId { get; set; } 
         [MaxLength(200)] 
         public string Title { get; set; } 
         public string Content { get; set; } 
 
         public int BlogId { get; set; } 
         public Blog Blog { get; set; }
         //public string Abstract { get; set; }
   }

}