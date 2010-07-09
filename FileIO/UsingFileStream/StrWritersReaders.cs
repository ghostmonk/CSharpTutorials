using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO.UsingFileStream
{
   class StrWritersReaders
   {
      public StrWritersReaders()
      {
         RunStringWriterReader();
         RunBinaryWriterReader();
      }

      private void RunStringWriterReader()
      {
         Console.WriteLine("*********** String Writer Reader **********");
         using (StringWriter strWriter = new StringWriter())
         {
            strWriter.WriteLine( "This is a string writer string entry" );
            Console.WriteLine( "This is what happens when you print out a string writer \" {0} \"", strWriter );

            StringBuilder strBuilder = strWriter.GetStringBuilder();
            strBuilder.Insert( 0, "Hey!" );
            Console.WriteLine( "-> {0}", strBuilder );
            strBuilder.Remove( 0, "Hey!".Length );
            Console.WriteLine( "-> {0}", strBuilder );

            using (StringReader strReader = new StringReader( strWriter.ToString() ))
            {
               string input;
               while ((input = strReader.ReadLine()) != null)
                  Console.WriteLine( input );
            }
         }
      }

      private void RunBinaryWriterReader()
      {
         Console.WriteLine( "*********** Binary Writer Reader **********" );
         FileInfo fileInfo = new FileInfo("BinFile.dat");
         
         using (BinaryWriter binWriter = new BinaryWriter(fileInfo.OpenWrite()))
         {
            Console.WriteLine("Base Stream is: {0}", binWriter.BaseStream);
            double aDouble = 1234.56;
            int aInt = 34456;
            string aString = "A, B, C";
            binWriter.Write(aDouble);
            binWriter.Write(aInt);
            binWriter.Write(aString);
         }

         using (BinaryReader reader = new BinaryReader( fileInfo.OpenRead() ))
         {
            Console.WriteLine( reader.ReadDouble() );
            Console.WriteLine( reader.ReadInt32() );
            Console.WriteLine( reader.ReadString() );
         }
      }
   }
}
