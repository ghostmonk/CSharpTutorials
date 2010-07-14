using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataProviderFactory
{
   class ConnectedLayer
   {
      public ConnectedLayer()
      {
         SqlConnection connection = StringBuilderConstructor();
         //SqlConnection connection = StringBuilderConnect();
         //SqlConnection connection = StringConnect();
         connection.Open();
         ShowConnectionStatus(connection);

         string query = "Select * From Inventory";
         SqlCommand command = new SqlCommand();
         command.Connection = connection;
         command.CommandText = query;

         SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection); 
         OutputResults( reader );
         reader.Close();
      }

      private SqlConnection StringBuilderConstructor()
      {
         SqlConnection connection = new SqlConnection();
         string connectionString = 
            @"Data Source=(local)\SQLEXPRESS;" +
            "Integrated Security=SSPI;" +
            "Initial Catalog=AutoLot;" +
            "Connect Timeout=30";
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
         builder.ConnectTimeout = 5;
         connection.ConnectionString = builder.ConnectionString;
         return connection;
      }

      private SqlConnection StringConnect()
      {
         SqlConnection connection = new SqlConnection();
         connection.ConnectionString = 
            @"Data Source=(local)\SQLEXPRESS;" +
            "Integrated Security=SSPI;" +
            "Initial Catalog=AutoLot;" +
            "Connect Timeout=30";
         return connection;
      }

      private SqlConnection StringBuilderConnect()
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
         builder.InitialCatalog = "AutoLot";
         builder.DataSource = @"(local)\SQLEXPRESS";
         builder.ConnectTimeout = 30;
         builder.IntegratedSecurity = true;

         SqlConnection connection = new SqlConnection();
         connection.ConnectionString = builder.ConnectionString;
         return connection;
      }

      private void ShowConnectionStatus( DbConnection connection )
      {
         Console.WriteLine("************Connection Info************");
         Console.WriteLine("Database Location: {0}", connection.DataSource);
         Console.WriteLine("Database Name: {0}", connection.Database);
         Console.WriteLine("Timeout: {0}", connection.ConnectionTimeout);
         Console.WriteLine("Connection State: {0}", connection.State);
      }

      private void OutputResults( SqlDataReader reader )
      {
         while (reader.Read())
         {
            Console.WriteLine("********Record*********");
            for (int i = 0; i < reader.FieldCount; i++ )
               Console.WriteLine("{0} = {1}", reader.GetName(i), reader.GetValue(i).ToString().Trim());
            Console.WriteLine();
         }
      }
   }
}
