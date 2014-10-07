using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{
			using (SchoolDBEntities db = new SchoolDBEntities())
			{
				Student studentEntity = db.Students.FirstOrDefault<Student>();
				var entitytype = ObjectContext.GetObjectType(studentEntity.GetType());
			}


			// Querying with EDM:
			// You can query EDM mainly by three ways, 1) LINQ to Entities 2) Entity SQL 3) Native SQL


			// 1) LINQ to Entities: L2E query syntax is easier to learn than Entity SQL. You can use your LINQ skills for querying with EDM. 
			//	  These are LINQ Method Syntax with Lamda expression and LINQ query syntax. LINQ Method syntax:
			//Querying with LINQ to Entities 
			using (var context = new SchoolDBEntities())
			{
				var L2EQuery = context.Students.Where(s => s.StudentName == "Bill");
			}
			// LINQ Query syntax:
			using (var context = new SchoolDBEntities())
			{
				var L2EQuery = from st in context.Students
											 where st.StudentName == "Bill"
											 select st;
			}

			// First, you have to create an object of context class, which is SchoolDBEntities. You should initialize it in using() so that once it goes out of scope then it will automatically call Dispose() method of DbContext. In both the syntax above, context returns IQueryable.
			//	We will learn different types of LINQ to Entities query in the projection query chapter later.


			// 2) Entity SQL: Entity SQL is another way to create a query. It is processed by the Entity Framework’s Object Services directly. It returns ObjectQuery instead of IQueryable.
			//	You need ObjectContext to create a query using Entity SQL.
			//	The following code snippet shows the same query result as L2E query above.

			//Querying with Object Services and Entity SQL
			using (var db = new SchoolDBEntities())
			{
				string sqlString = "SELECT VALUE st FROM SchoolDBEntities.Students AS st  WHERE st.StudentName == 'Bill'";

				ObjectContext objctx = ((IObjectContextAdapter)db).ObjectContext;
				ObjectQuery<Student> student = objctx.CreateQuery<Student>(sqlString);
				Student newStudent = student.First<Student>();
			}

			// You can also use EntityConnection and EntityCommand to execute Entity SQL as shown below:
			using (var con = new EntityConnection("name=SchoolDBEntities"))
			{
				con.Open();
				EntityCommand cmd = con.CreateCommand();
				cmd.CommandText = "SELECT VALUE st FROM SchoolDBEntities.Students as st where st.StudentName='Bill'";
				Dictionary<int, string> dict = new Dictionary<int, string>();
				using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
				{
					while (rdr.Read())
					{
						int a = rdr.GetInt32(0);
						var b = rdr.GetString(1);
						dict.Add(a, b);
					}
				}
			}
			// EntityDataReader doesn't return ObjectQuery, instead it returns the data in rows & columns.
			// Visit MSDN blog to learn Entity SQL.
			
			
			// 3) Native SQL You can execute native SQL queries for a relational database as shown below:
			using (var ctx = new SchoolDBEntities())
			{
				var studentName = ctx.Students.SqlQuery("Select studentid, studentname, standardId from Student where studentname='Bill'").FirstOrDefault<Student>();
			}




		}
	}
}
