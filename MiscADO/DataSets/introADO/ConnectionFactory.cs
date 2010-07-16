using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;

namespace MiscADO.introADO
{
   class ConnectionFactory
   {
      public ConnectionFactory()
      {
         string dataProvString = ConfigurationManager.AppSettings["provider"];

         DataProvider dataProvider = DataProvider.None;

         if (Enum.IsDefined( typeof( DataProvider ), dataProvString ))
            dataProvider = (DataProvider) Enum.Parse(typeof (DataProvider), dataProvString);
         else 
            Console.WriteLine("Sorry no provider exists!");

         IDbConnection connection = GetConnection(dataProvider);

         if( connection != null )
            Console.WriteLine("Your connection is a {0}", connection.GetType().Name);
      }

      private IDbConnection GetConnection(DataProvider provider)
      {
         IDbConnection connection = null;

         switch (provider)
         {
            case DataProvider.SqlServer:
               connection = new SqlConnection();
               break;
            case DataProvider.OleDb:
               connection = new OleDbConnection();
               break;
            case DataProvider.Odbc:
               connection = new OdbcConnection();
               break;
         }

         return connection;
      }
   }

   enum DataProvider
   {
      SqlServer, OleDb, Odbc, Oracle, None
   }
}
