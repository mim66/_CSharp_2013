using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace School_CodeFirst
{
	public class CSeedingDataWithCustomDBInitializer
	{
		public void PokazDane()
		{
			using (var ctx = new TestContext5())
			{
				new DBInitializer5().InitializeDatabase(ctx);

				foreach (var s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class Student5
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	public class DBInitializer5 : DropCreateDatabaseAlways<TestContext5>
	{
		List<Student5> studentsList = new List<Student5>();
		public DBInitializer5()
		{
			studentsList.Add(new Student5 { Name = "sourav", Surname = "kayal" });
			studentsList.Add(new Student5 { Name = "foo", Surname = "bar" });
		}
		protected override void Seed(TestContext5 context)
		{
			foreach (Student5 p in studentsList)
			{
				context.Students.Add(p);
			}
			context.SaveChanges();
			base.Seed(context);
		}

	}

	public class TestContext5 : DbContext
	{
		public TestContext5()	: base("EFTest")
		{
			Database.SetInitializer<TestContext5>(new DBInitializer5());
		}
		public DbSet<Student5> Students { get; set; }
	}

	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}
