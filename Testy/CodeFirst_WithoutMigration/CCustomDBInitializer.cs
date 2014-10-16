using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace School_CodeFirst
{
	public class CCustomDBInitializer
	{
		public void PokazDane()
		{
			using (var ctx = new TestContext4())
			{
				new DBInitializer().InitializeDatabase(ctx);

				foreach (var s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class Student4
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	public class DBInitializer : DropCreateDatabaseAlways<TestContext4>
	{
		protected override void Seed(TestContext4 context)
		{
			base.Seed(context);
		}
	}

	public class TestContext4 : DbContext
	{
		public TestContext4()	: base("EFTest")	{
			Database.SetInitializer<TestContext4>(new DBInitializer());
		}
		public DbSet<Student4> Students { get; set; }
	}

	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}

