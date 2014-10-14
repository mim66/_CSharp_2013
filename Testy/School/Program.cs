using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
//using System.Data.EntityClient;
//using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("*** Please debug code for better understanding ***");
			Console.WriteLine("");
			Console.WriteLine("*** EntityFramework 5.0 Basic Tutorials Demo Start ***");
			Console.WriteLine("");

			//EF5.DynamicProxyDemo();
			//Linia();
			//EF5.FindEntityDemo();
			//Linia();
			//EF5.LazyLoadingDemo();
			//Linia();
			//EF5.ExplicitLoadingDemo();
			//Linia();
			//EF5.RawSQLtoEntityTypeDemo();
			//Linia();
			//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
			//EF5.ReadDataUsingStoredProcedure();
			//Linia();
			// nieaktywne
			//EF5.ReadDataUsingStoredProcedure2();
			//EF5.RawSQLCommandDemo();
			//Linia();
			//EF5.EntitySQLDemo();
			//Linia();
			//EF5.EntitySQLUsingEntityConnectionDemo();
			//Linia();
			//EF5.SpatialDataTypeDemo();
			//Linia();
			//EF5.GetPropertyValuesDemo();
			//Linia();
			//EF5.LocalDemo();
			//Linia();
			//EF5.ChangeTrackingDemo();
			//Linia();
			//EF5.SetValuesDemo();
			//Linia();
			//EF5.ValidationErrorDemo();
			//Linia();
			//EF5.CRUDOperationInConnectedScenarioDemo();
			//Linia();
			//EF5.OptimisticConcurrencyDemo();
			//Linia();
			
			//Add and map sp_InsertStudentInfo, sp_UpdateStudent and sp_DeleteStudent into EDM to run following demo
			//EF5.CUDOperationUsingStoredProcedureDemo();

			//AddDemo.AddSingleEntity();
			//AddDemo.AddEntityGraph();

			UpdateDemo.UpdateSingleEntity();
			UpdateDemo.UpdateEntityGraphUsingId();


			//Implement IEntityObjectState in Standard & Teacher entity class to run following demo
			//UpdateDemo.UpdateEntityGraphUsingStateProperty();

			Console.WriteLine("*** EntityFramework 5.0 Basic Tutorials Demo Finished ***");
			Console.ReadKey();

		}

		private static void Linia()
		{
			Console.WriteLine("");
		}


	}
}
