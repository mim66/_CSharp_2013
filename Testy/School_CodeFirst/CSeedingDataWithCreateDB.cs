using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace School_CodeFirst
{
	public class CSeedingDataWithCreateDB
	{
		public void PokazDane() {
			using (var ctx = new TestContext6())	{
				//Student6 stu = new Student6() { Name = "Name", Surname = "surname" };
				//ctx.Students.Add(stu);
				//ctx.SaveChanges();
				foreach (Student6 s in ctx.Students)	{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class TestContext6 : DbContext
	{
		public TestContext6()	: base("EFTest")
		{
			Database.SetInitializer<TestContext6>(new CreateDatabaseIfNotExists<TestContext6>());
		}
		public DbSet<Student6> Students { get; set; }
	}

	public class Student6
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
	}




	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}
