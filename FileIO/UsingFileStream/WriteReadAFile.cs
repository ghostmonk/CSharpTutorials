using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.UsingFileStream
{
   class WriteReadAFile
   {
      private const string FILE_NAME = "reminders.txt";

      public WriteReadAFile()
      {
         Write();
         Read();
      }

      private void Write()
      {
         Console.WriteLine( "********* Writing to a file *********" );

         using (StreamWriter writer = File.CreateText( FILE_NAME ))
         {
            writer.WriteLine( "Don't forget Mother's day this year..." );
            writer.WriteLine( "Don't forget Father's day this year..." );
            writer.WriteLine( "Don't forget these numbers:" );
            for (int i = 1; i < 11; i++)
               writer.Write( i + " " );
            writer.Write( writer.NewLine );
         }
      }

      private void Read()
      {
         Console.WriteLine( "********* Reading from {0} *********", FILE_NAME );

         using(StreamReader reader = File.OpenText(FILE_NAME))
         {
            string input;
            while((input = reader.ReadLine()) != null)
               Console.WriteLine(input);
         }
      }
   }
}
