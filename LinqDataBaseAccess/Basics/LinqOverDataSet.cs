using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AutoLotConnectedLayer;

namespace LinqDataBaseAccess.Basics
{
   internal class LinqOverDataSet
   {
      public LinqOverDataSet()
      {
         var builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(local)\SQLEXPRESS",
            InitialCatalog = "AutoLot",
            IntegratedSecurity = true
         };
         var layer = new AutoLotDisconnectedLayer( builder.ConnectionString );
         DataTable data = layer.GetAllInventory();
         PrintCarIDs( data );
         ApplyLinqQuery( data );
         HydrateTable( data );
      }

      private void PrintCarIDs( DataTable table )
      {
         IEnumerable<DataRow> enumData = table.AsEnumerable();

         foreach( DataRow row in enumData )
            Console.WriteLine( "Car ID = {0}", row["CarID"] );
      }

      private void ApplyLinqQuery( DataTable data )
      {
         var cars = from car in data.AsEnumerable()
                    where car.Field<int>( "CarID" ) > 5
                    //where (int)car["CarID"] > 5
                    select new
                    {
                       ID = car.Field<int>( "CarID" ),
                       //ID = (int)car["CarID"],
                       Color = car.Field<string>( "Color" ),
                       //Color = (string)car["Color"],
                    };

         foreach( var car in cars )
            Console.WriteLine( "CarID = {0} is {1}", car.ID, car.Color );
      }

      private void HydrateTable( DataTable data )
      {
         var cars = from car in data.AsEnumerable()
                    where car.Field<int>( "CarID" ) > 5
                    select car;

         DataTable newData = cars.CopyToDataTable();

         for( int row = 0; row < newData.Rows.Count; row++ )
         {
            for( int col = 0; col < newData.Columns.Count; col++ )
               Console.WriteLine( newData.Rows[row][col].ToString().Trim() + "\t" );
            Console.WriteLine();
         }
      }
   }
}