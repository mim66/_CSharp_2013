using System;
using System.Collections.Generic;
using System.Data;
// to use EntityConnection
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;

namespace EFBasicTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Please debug code for better understanding ***");
            Console.WriteLine("");
            Console.WriteLine("*** EntityFramework 5.0 Basic Tutorials Demo Start ***");
            Console.WriteLine("");

            EF5.DynamicProxyDemo();
            EF5.FindEntityDemo();
            EF5.LazyLoadingDemo();
            EF5.ExplicitLoadingDemo();
            EF5.RawSQLtoEntityTypeDemo();
            EF5.ReadDataUsingStoredProcedure();
            EF5.RawSQLCommandDemo();
            EF5.EntitySQLDemo();
            EF5.EntitySQLUsingEntityConnectionDemo();
            EF5.SpatialDataTypeDemo();
            EF5.GetPropertyValuesDemo();
            EF5.LocalDemo();
            EF5.ChangeTrackingDemo();
            EF5.SetValuesDemo();
            EF5.ValidationErrorDemo();
            EF5.CRUDOperationInConnectedScenarioDemo();
            EF5.OptimisticConcurrencyDemo();
            //Add and map sp_InsertStudentInfo, sp_UpdateStudent 
            //and sp_DeleteStudent into EDM to run following demo
            //EF5.CUDOperationUsingStoredProcedureDemo();

            AddDemo.AddSingleEntity();
            AddDemo.AddEntityGraph();

            UpdateDemo.UpdateSingleEntity();
            UpdateDemo.UpdateEntityGraphUsingId();


            //Implement IEntityObjectState in Standard & Teacher entity class to run following demo
            //UpdateDemo.UpdateEntityGraphUsingStateProperty();

            Console.WriteLine("*** EntityFramework 5.0 Basic Tutorials Demo Finished ***");
            Console.ReadKey();

        }

      

        
    }
}
