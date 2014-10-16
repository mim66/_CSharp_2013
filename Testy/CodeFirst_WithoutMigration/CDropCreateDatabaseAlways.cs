using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace School_CodeFirst
{
	public class CDropCreateDatabaseAlways
	{
		public void PokazDane() {
			using (var ctx = new TestContext2())
			{
				Student2 stu = new Student2() { Name = "Name2", Surname = "Surname2" };
				ctx.Students.Add(stu);
				ctx.SaveChanges();
				foreach (var s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class Student2
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	public class TestContext2 : DbContext
	{
		public TestContext2()	: base("EFTest")	{
			//Create database always, even If exists
			Database.SetInitializer<TestContext2>(new DropCreateDatabaseAlways<TestContext2>());
		}
		public DbSet<Student2> Students { get; set; }
	}



	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}

