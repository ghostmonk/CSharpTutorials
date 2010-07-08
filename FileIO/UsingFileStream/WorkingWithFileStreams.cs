using System;
using System.IO;
using System.Text;

namespace FileIO.UsingFileStream
{
   class WorkingWithFileStreams
   {
      public WorkingWithFileStreams()
      {
         string fileLoc = Environment.CurrentDirectory + @"\message.dat";
         using( FileStream stream = File.Open(fileLoc, FileMode.Create) )
         {
            string msg = "Hello!";
            byte[] msgByteArray = Encoding.Default.GetBytes(msg);
            stream.Write(msgByteArray, 0, msgByteArray.Length);
            stream.Position = 0;
            Console.WriteLine("****Message as a ByteArray*****");
            byte[] bytesFromFile = new byte[msgByteArray.Length];

            for( int i = 0; i < msgByteArray.Length; i++)
            {
               bytesFromFile[i] = (byte) stream.ReadByte();
               Console.WriteLine(bytesFromFile[i]);
            }
            Console.WriteLine("\nDecoded Message");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
         }
      }
   }
}
