using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AutoLotClient.Utils;

namespace MiscADO.DataAdapting
{
   class SimpleDataAdapter
   {
      private const string SelectAllCmd = "Select * From Inventory";

      public SimpleDataAdapter()
      {
         SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
         {
            DataSource = @"(local)\SQLEXPRESS",
            IntegratedSecurity = true,
            InitialCatalog = "AutoLot"
         };

         DataSet set = new DataSet( "AutoLot" );

         SqlDataAdapter adapter = new SqlDataAdapter( SelectAllCmd, builder.ConnectionString );

         DataTableMapping map = adapter.TableMappings.Add( "Inventory", "Current Inventory" );
         map.ColumnMappings.Add( "CarID", "Car ID" );
         map.ColumnMappings.Add( "PetName", "Name of Car" );

         adapter.Fill( set, "Inventory" );

         Console.WriteLine( DbUtils.DataSetToString( set ) );
      }
   }
}
