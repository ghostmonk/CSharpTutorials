using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AutoLotClient.Utils
{
   public class DbUtils
   {
      public static string TableToString(DataTable table)
      {
         StringBuilder builder = new StringBuilder();
         
         for (int curCol = 0; curCol < table.Columns.Count; curCol++)
            builder.Append( table.Columns[curCol].ColumnName.Trim() + "\t" );
         
         builder.Append( "\n----------------------------------------\n" );

         for (int curRow = 0; curRow < table.Rows.Count; curRow++)
         {
            for (int curCol = 0; curCol < table.Columns.Count; curCol++)
               builder.Append( table.Rows[curRow][curCol].ToString().Trim() + "\t" );
            builder.Append( "\n" );
         }

         return builder.ToString();
      }

      public static string ReaderToString( IDataReader reader )
      {
         StringBuilder builder = new StringBuilder();
         while (reader.Read())
         {
            builder.Append( "\n*****RECORD******\n" );
            for (int i = 0; i < reader.FieldCount; i++)
               builder.Append( string.Format( "{0} = {1}", reader.GetName( i ), reader.GetValue( i ).ToString().Trim() ) );
            builder.Append("\n");
         }
         return builder.ToString();
      }
   }
}
