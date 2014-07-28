using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CodeFirstExistingDatabaseSample
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new BloggingContext())
			{
				// Create adn sabve a new blog
				Console.WriteLine("Enter a name for a new blog: ");
				var _name = Console.ReadLine();

				var _blog = new Blog { Name = _name };
				db.Blogs.Add(_blog);
				db.SaveChanges();

				// Display all Blogs from the database 
				var query = from b in db.Blogs
										orderby b.Name
										select b;

				Console.WriteLine("All blogs in the database:");
				foreach (var item in query)
				{
					Console.WriteLine(item.Name);
				}

				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
			}
		}
	}
}
