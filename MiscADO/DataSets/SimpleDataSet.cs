using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AutoLotClient.Utils;

namespace MiscADO.DataSets
{
   class SimpleDataSet
   {

      public SimpleDataSet()
      {
         DataSet inventory = GetInventory( "Car Inventory" );
         DataTable inventoryTable = new DataTable( "Inventory" );
         AddColumns( inventoryTable );
         AddRows( inventoryTable );
         inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };
         inventory.Tables.Add( inventoryTable );
         Console.WriteLine( DbUtils.DataSetToString( inventory ) );
         DbUtils.SaveDataSetAsBinary( inventory, "carInventory" );
         DbUtils.SaveDataSetAsXml( inventory, "carInventory" );
      }

      private DataSet GetInventory(string title)
      {
         DataSet inventory = new DataSet( title );
         inventory.ExtendedProperties["TimeStamp"] = DateTime.Now;
         inventory.ExtendedProperties["DataSetID"] = Guid.NewGuid();
         inventory.ExtendedProperties["Company"] = "Ghostmonk Designs";
         return inventory;
      }

      private void AddColumns(DataTable inventoryTable)
      {
         DataColumn idColumn = new DataColumn( "CarID", typeof( int ) );
         idColumn.Caption = "Car ID";
         idColumn.ReadOnly = true;
         idColumn.AllowDBNull = false;
         idColumn.Unique = true;
         idColumn.AutoIncrement = true;
         idColumn.AutoIncrementSeed = 0;
         idColumn.AutoIncrementStep = 1;

         DataColumn makeColumn = new DataColumn( "Make", typeof( string ) );
         DataColumn colorColumn = new DataColumn( "Color", typeof( string ) );
         DataColumn nameColumn = new DataColumn( "PetName", typeof( string ) );
         nameColumn.Caption = "Pet Name";

         inventoryTable.Columns.AddRange( new DataColumn[] { idColumn, makeColumn, colorColumn, nameColumn } );
      }

      private void AddRows(DataTable inventoryTable)
      {
         DataRow row = inventoryTable.NewRow();
         row["Make"] = "BMW";
         row["Color"] = "Black";
         row["PetName"] = "Hamlet";
         inventoryTable.Rows.Add( row );

         row = inventoryTable.NewRow();
         row[1] = "Saab";
         row[2] = "Red";
         row[3] = "Sea Breeze";
         inventoryTable.Rows.Add( row );
      }
   }
}
