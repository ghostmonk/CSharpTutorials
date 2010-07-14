using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using AutoLotClient.Utils;

namespace MiscADO.AsyncCmdObject
{
   class AsyncConnect
   {
      public AsyncConnect()
      {
         SqlConnection connection = new SqlConnection();
         SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
         connectionBuilder.DataSource = @"(local)\SQLEXPRESS";
         connectionBuilder.IntegratedSecurity = true;
         connectionBuilder.AsynchronousProcessing = true;
         connectionBuilder.InitialCatalog = "AutoLot";
         connection.ConnectionString = connectionBuilder.ConnectionString;
         connection.Open();

         string query = "WaitFor Delay '00:00:05';Select * From Inventory";
         SqlCommand command = new SqlCommand(query, connection);

         IAsyncResult connectionResult = command.BeginExecuteReader(CommandBehavior.CloseConnection);

         while (!connectionResult.IsCompleted)
         {
            Console.WriteLine("Working on Main thread...");
            Thread.Sleep(1000);
         }
         Console.WriteLine();

         SqlDataReader reader = command.EndExecuteReader(connectionResult);

         Console.WriteLine(DbUtils.ReaderToString(reader));
      }
   }
}
