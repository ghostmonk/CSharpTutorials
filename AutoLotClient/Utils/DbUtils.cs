using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

namespace AutoLotClient.Utils
{
   public class DbUtils
   {
      private const string extPattern = "\\.[a-zA-Z]*";

      public static string TableToString(DataTable table)
      {
         StringBuilder builder = new StringBuilder();

         builder.Append( "Table " + table.TableName + "\n" );

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

      public static string ReaderToString(IDataReader reader)
      {
         StringBuilder builder = new StringBuilder();
         while (reader.Read())
         {
            builder.Append( "\n*****RECORD******\n" );
            for (int i = 0; i < reader.FieldCount; i++)
               builder.Append( string.Format( "{0} = {1}", reader.GetName( i ), reader.GetValue( i ).ToString().Trim() ) );
            builder.Append( "\n" );
         }
         return builder.ToString();
      }

      public static string DataSetToString(DataSet set)
      {
         StringBuilder builder = new StringBuilder();

         builder.Append( "DataSet: " + set.DataSetName );

         foreach (DictionaryEntry entry in set.ExtendedProperties)
            builder.Append( string.Format( "\nKey = {0}, Value = {1}", entry.Key, entry.Value ) );
         builder.Append( "\n" );

         foreach (DataTable table in set.Tables)
            builder.Append( "\n" + TableToString( table ) );

         return builder.ToString();
      }

      public static void SaveDataSetAsXml(DataSet set, string fileName)
      {
         string file = Regex.Replace( fileName, extPattern, fileName );
         fileName = VerifyFileExt( fileName, ".xml" );

         set.WriteXml( fileName );
         set.WriteXmlSchema( file + ".xsd" );
      }

      public static void SaveDataSetAsBinary(DataSet set, string fileName)
      {
         set.RemotingFormat = SerializationFormat.Binary;
         fileName = VerifyFileExt(fileName, ".bin");

         FileStream stream = new FileStream( fileName, FileMode.Create );
         BinaryFormatter formatter = new BinaryFormatter();
         formatter.Serialize( stream, set );
         stream.Close();
      }

      public static string VerifyFileExt( string fileName, string defaultExt )
      {
         return Regex.Match( fileName, extPattern ).ToString().Length == 0 ? fileName + defaultExt : fileName;
      }
   }
}
