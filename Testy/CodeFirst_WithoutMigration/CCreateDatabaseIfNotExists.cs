using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_CodeFirst
{
	public class CCreateDatabaseIfNotExists
	{
		public void PokazDane() {
			using (var ctx = new TestContext())
			{
				Student stu = new Student() { Name = "Name", Surname = "surname" };
				ctx.Students.Add(stu);
				ctx.SaveChanges();
				foreach (Student s in ctx.Students)
				{
					Console.WriteLine("Osoba: {0}, {1}", s.Surname, s.Name);
				}
			}
		}
	}

	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		[MaxLength(10)]
		public string Name { get; set; }
		public string Surname { get; set; }
	}

	public class TestContext : DbContext
	{
		public TestContext()	: base("EFTest")	{
			//Create database always, even If exists
			Database.SetInitializer<TestContext>(new CreateDatabaseIfNotExists<TestContext>());
		}
		public DbSet<Student> Students { get; set; }
	}



	// dodaj wpis do app.config  lub web.config
	//
	//<connectionStrings>
	//	<add name="EFTest"
	//	connectionString="Data Source=.\SqlExpress;Initial Catalog=_EFTest;Integrated Security=true"
	//	providerName="System.Data.SqlClient"/>
	//</connectionStrings>
}
