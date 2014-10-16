using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_CodeFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1. Create database if it does not exist");
			Console.WriteLine("   This is default initializer. As name suggests, it will create the database if none exists ");
			Console.WriteLine("   as per the configuration. However, if you change the model class and then run the application ");
			Console.WriteLine("   with this initializer, then it will throw an exception.");
			//CCreateDatabaseIfNotExists one = new CCreateDatabaseIfNotExists();
			//one.PokazDane();

			Console.WriteLine();
			Console.WriteLine("2. Create database always");
			Console.WriteLine("   DropCreateDatabaseIfModelChanges: This initializer drops an existing database and creates a new database, ");
			Console.WriteLine("   if your model classes (entity classes) have been changed. So you don’t have to worry ");
			Console.WriteLine("   about maintaining your database schema, when your model classes change.");
			//CDropCreateDatabaseAlways two = new CDropCreateDatabaseAlways();
			//two.PokazDane();


			Console.WriteLine();
			Console.WriteLine("3. Create database when model changes");
			Console.WriteLine("   As the name suggests, this initializer drops an existing database every time you run the application, ");
			Console.WriteLine("   irrespective of whether your model classes have changed or not. This will be useful, ");
			Console.WriteLine("   when you want fresh database, every time you run the application, while you are developing the application.");
			//CCreateDatabaseWhenModelChanges three = new CCreateDatabaseWhenModelChanges();
			//three.PokazDane();

			Console.WriteLine();
			Console.WriteLine("4. Custom DB Initializer");
			Console.WriteLine("   You can also create your own custom initializer, if any of the above don't satisfy your requirements ");
			Console.WriteLine("   or you want to do some other process that initializes the database using above initializer.");
			//CCustomDBInitializer four = new CCustomDBInitializer();
			//four.PokazDane();

			Console.WriteLine();
			Console.WriteLine("   Seeding Data with Custom DB Initializer ");
			//CSeedingDataWithCustomDBInitializer five = new CSeedingDataWithCustomDBInitializer();
			//five.PokazDane();

			Console.WriteLine();
			Console.WriteLine("   Seeding Data with Custom DB Initializer and Create database if it does not exist only");
			Console.WriteLine("   In Packige Manager Console write 'Enable-Migrations -ContextTypeName School_CodeFirst.TestContext6'");
			using (var ctx = new TestContext6())
			{
				//Student6 stu = new Student6() { Name = "Name", Surname = "surname" };
				//ctx.Students.Add(stu);
				//ctx.SaveChanges();
				foreach (Student6 s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}

			Console.ReadLine();
		}
	}
}
