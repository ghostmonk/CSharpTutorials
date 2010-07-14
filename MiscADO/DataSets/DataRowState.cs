using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MiscADO.DataSets
{
   class DataRowState
   {
      public DataRowState()
      {
         DataTable table = new DataTable( "Temp" );
         table.Columns.Add( new DataColumn( "TempColumn", typeof( int ) ) );

         DataRow row = table.NewRow();
         Console.WriteLine( "After calling NewRow(): {0}", row.RowState );

         table.Rows.Add( row );
         Console.WriteLine( "After calling Rows.Add(): {0}", row.RowState );

         row["TempColumn"] = 10;
         Console.WriteLine( "After first assignment: {0}", row.RowState );

         table.AcceptChanges();
         Console.WriteLine( "After calling AcceptChanges: {0}", row.RowState );

         row["TempColumn"] = 11;
         Console.WriteLine( "After Modification: {0}", row.RowState );

         table.Rows[0].Delete();
         Console.WriteLine( "After calling Delete: {0}", row.RowState );
      }
   }
}
