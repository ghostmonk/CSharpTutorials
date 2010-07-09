using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace FileIO.FileSystem
{
   class AsyncFileStream
   {
      public AsyncFileStream()
      {
         Console.WriteLine("Main Thread started. ThreadID = {0}", Thread.CurrentThread.GetHashCode());
         FileStream stream = new FileStream("logfile.txt", FileMode.Append, FileAccess.Write, FileShare.None, 4096, true);
         string msg = "This is a Test";
         byte[] buffer = Encoding.ASCII.GetBytes(msg);

         stream.BeginWrite(buffer, 0, buffer.Length, WriteDone, stream);
      }

      private void WriteDone(IAsyncResult result)
      {
         Console.WriteLine("AsyncCallback method on ThreadID = {0}", Thread.CurrentThread.GetHashCode());

         Stream stream = (Stream) result.AsyncState;
         stream.EndWrite(result);
         stream.Close();
      }
   }
}
