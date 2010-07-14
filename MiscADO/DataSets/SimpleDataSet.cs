using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

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
         PrintDataSet( inventory );
      }

      private void PrintDataSet(DataSet set)
      {
         Console.WriteLine( "DataSet : {0}", set.DataSetName );

         foreach (DictionaryEntry entry in set.ExtendedProperties)
            Console.WriteLine( "Key = {0}, Value = {1}", entry.Key, entry.Value );
         Console.WriteLine();

         foreach (DataTable table in set.Tables)
         {
            Console.WriteLine( "=> {0} Table:", table.TableName );

            for (int col = 0; col < table.Columns.Count; col++)
            {
               Console.WriteLine( table.Columns[col].ColumnName + "\t" );
            }
            Console.WriteLine("\n------------------------------------------");

            for (int row = 0; row < table.Rows.Count; row++)
            {
               for (int col = 0; col < table.Columns.Count; col++)
                  Console.Write(table.Rows[row][col].ToString() + "\t");
               Console.WriteLine();
            }
         }
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
