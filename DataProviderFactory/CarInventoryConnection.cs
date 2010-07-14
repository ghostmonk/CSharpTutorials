using System;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace DataProviderFactory
{
   class CarInventoryConnection
   {
      public CarInventoryConnection()
      {
         string dataProvider = ConfigurationManager.AppSettings["provider"];
         string connectionStr = ConfigurationManager.ConnectionStrings["AutoLotOleDbProvider"].ConnectionString;

         DbProviderFactory factory = DbProviderFactories.GetFactory( dataProvider );

         DbConnection connection = factory.CreateConnection();
         connection.ConnectionString = connectionStr;
         connection.Open();

         DbCommand command = factory.CreateCommand();
         command.Connection = connection;
         command.CommandText = "Select * From Inventory";

         DbDataReader reader = command.ExecuteReader( CommandBehavior.CloseConnection );

         Console.WriteLine( "Connection = {0}", connection.GetType().Name );
         Console.WriteLine( "Command Object = {0}", command.GetType().Name );
         Console.WriteLine( "Reader Object = {0}", reader.GetType().Name );

         Console.WriteLine( "Inventory" );

         while (reader.Read())
            Console.WriteLine( "-> Car #{0} is a {1}.", reader["CarID"], reader["Make"].ToString().Trim() );
         reader.Close();
      }
   }
}
