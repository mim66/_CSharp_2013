using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace School_CodeFirst
{
	public class CCreateDatabaseWhenModelChanges
	{
		public void PokazDane()
		{
			using (var ctx = new TestContext3())
			{
				Student3 stu = new Student3() { Name = "Name3", Surname = "Surname3" };
				ctx.Students.Add(stu);
				ctx.SaveChanges();
				foreach (var s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class Student3
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
		//dodatkowe pole 
		//public string Surname2 { get; set; }
	}

	public class TestContext3 : DbContext
	{
		public TestContext3()
			: base("EFTest")
		{
			//Create database always, even If exists
			Database.SetInitializer<TestContext3>(new DropCreateDatabaseIfModelChanges<TestContext3>());
		}
		public DbSet<Student3> Students { get; set; }
	}

	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}

